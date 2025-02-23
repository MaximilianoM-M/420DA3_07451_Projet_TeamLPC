﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using System.Diagnostics;


namespace _420DA3_07451_Projet_Initial.Business.Services;
public class PurchaseOrderService : AbstractDtoService<PurchaseOrder, int> {

    protected override PurchaseOrderDAO Dao { get; }
    protected override PurchaseOrderForm DtoManagementWindow { get; }
    protected ProduitDAO ProduitDAO { get; }

    /// <summary>
    /// Declaration du constructeur 
    /// </summary>
    /// <param name="facade"></param>
    /// <param name="context"></param>
    public PurchaseOrderService(AbstractFacade facade, AbstractContext context) {
        facade.RegisterDependent(this);
        this.Dao = new PurchaseOrderDAO(context);
        this.DtoManagementWindow = new PurchaseOrderForm(facade);
        this.ProduitDAO = new ProduitDAO(context);
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public override void Shutdown() {
        if (!this.DtoManagementWindow.IsDisposed) {
            this.DtoManagementWindow.Dispose();
        }
    }
    //Methode qui retourne tout les incompleted purchase order
    public List<PurchaseOrder> GetPurchaseOrder() {
        return this.Dao.GetAll();
    }


    public List<PurchaseOrder> GetIncompleteForWarehouse(Entrepot entrepot) {
        return this.Dao.GetIncompleteForWarehouse(entrepot.Id);
    }


    public PurchaseOrder CompletePurchaseOrder(PurchaseOrder purchaseOrder) {
        Produit produit = purchaseOrder.Product;
        produit.InstockQuantity += purchaseOrder.QuantityOrdered;
        _ = this.ProduitDAO.Update(produit);
        purchaseOrder.Status = PurchaseOrderStatusEnum.Completed;
        _ = this.Dao.Update(purchaseOrder);

        return purchaseOrder;

        
    }

}
