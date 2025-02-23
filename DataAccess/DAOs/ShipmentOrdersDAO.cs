﻿using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;

public class ShipmentOrdersDAO : AbstractDao<ShipmentOrderDTO, int> {


    protected override AbstractContext Context { get; }

    /// <summary>
    /// Initialisation du contexte dans la classe ShipmentOrdersDAO
    /// </summary>
    /// <param name="context"></param>
    public ShipmentOrdersDAO(AbstractContext context) {

        this.Context = context;
    }

    /// <summary>
    /// Obtient la liste des nouvelle commande pour un entrepot specifique 
    /// </summary>
    /// <param name="entrepotId"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetNewOrdersForWarehouse(int entrepotId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status == ShippingOrderStatusEnum.NEW && order.EntrepotOriginalId == entrepotId)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.Produit)
            .Include(so => so.Shipment)
            .ToList();
    }

    /// <summary>
    /// Obtien la liste des commande incomplete assigner a un employe de bureau attitre
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetIncompleteOrdersAssignedTo(int userId) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(order => order.Status != ShippingOrderStatusEnum.COMPLETED && order.EmployeEntrepotId == userId)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.Produit)
            .Include(so => so.Shipment)
            .ToList();
    }

    /// <summary>
    /// Obtien la liste des commande selon le client specifique 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public List<ShipmentOrderDTO> GetClientShipmentOrderById(int id) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Where(client => client.ClientsId == id)
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.Produit)
            .Include(so => so.Shipment)
            .ToList();

    }
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    public override List<ShipmentOrderDTO> GetAll() {

        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.Produit)
            .Include(so => so.Shipment)
            .ToList();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="identifier"></param>
    /// <returns></returns>
    public override ShipmentOrderDTO? GetById(int identifier) {

        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.Produit)
            .Include(so => so.Shipment)
            .Where(so => so.Id == identifier)
            .SingleOrDefault();
    }

    public List<ShipmentOrderDTO> SearchShipmentOrder(string filter) {
        return this.Context.GetDbSet<ShipmentOrderDTO>()
            .Include(so => so.Clients)
            .Include(so => so.EntrepotOriginal)
            .Include(so => so.EmployeEntrepot)
            .Include(so => so.AssociationsProduits)
                .ThenInclude(sop => sop.Produit)
            .Include(so => so.Shipment)
            .Where(so => so.Id.ToString().StartsWith(filter) || so.Clients.CompanyName.StartsWith(filter))
            .ToList();
    }
}
