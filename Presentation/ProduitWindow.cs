﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation.Abstracts;
using _420DA3_07451_Projet_Initial.Presentation.Enums;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class ProduitWindow : Form, IDtoManagementView<Produit> {

    private readonly AbstractFacade facade;
    private Produit produit = null!;
    private ViewIntentEnum workingIntent;

    public ProduitWindow(AbstractFacade facade) {
        this.facade = facade;

        this.InitializeComponent();

    }
    private void LoadClientComboBox() {
        this.clientComboBox.DataSource = this.facade.GetService<ClientService>().GetAllClients();

    }

    private void LoadSupplierComboBox() {
        this.supplierComboBox.DataSource = this.facade.GetService<FournisseurService>().GetAllFournisseur();
    }



    #region Public Methods
    public DialogResult OpenForCreation(Produit blankInstance) {
        this.workingIntent = ViewIntentEnum.Creation;
        this.actionBtn.Text = "Creer";
        return this.OpenFor(blankInstance);
    }
    public DialogResult OpenForVisualization(Produit instance) {
        this.workingIntent = ViewIntentEnum.Visualization;
        this.actionBtn.Text = "OK";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForEdition(Produit instance) {
        this.workingIntent = ViewIntentEnum.Edition;
        this.actionBtn.Text = "Enregistrer";
        return this.OpenFor(instance);
    }

    public DialogResult OpenForDeletion(Produit instance) {

        this.workingIntent = ViewIntentEnum.Deletion;
        this.actionBtn.Text = "Supprimer";
        return this.OpenFor(instance);
    }


    #endregion



    #region Private Methods
    private DialogResult OpenFor(Produit instance) {
        this.LoadSupplierComboBox();
        this.LoadClientComboBox();
        this.produit = instance;
        switch (this.workingIntent) {
            case ViewIntentEnum.Visualization:
            case ViewIntentEnum.Deletion:
                this.DisableControls();
                break;
            case ViewIntentEnum.Creation:
            case ViewIntentEnum.Edition:
                this.EnableControls();
                break;
            default:
                throw new Exception("View Intent not supported");

        }

        this.LoadProduitDataInControls(instance);
        return this.ShowDialog();
    }
    private void SaveDataInInstance() {
        this.ValidateFields();
        this.produit.UpcCode = (int) this.upcCodeNumUpDown.Value;
        this.produit.Name = this.nameTextBox.Text;
        this.produit.Description = this.descriptionTextBox.Text;
        this.produit.SupplierCode = this.supplierCodeTextBox.Text;
        this.produit.DoAutoRestock = this.AutoCheckBox.Checked;
        this.produit.InstockQuantity = (int) this.qtyInStockNumeric.Value;
        this.produit.ClientsDTO = (ClientsDTO) this.clientComboBox.SelectedItem;
        this.produit.Fournisseur = (Fournisseur) this.supplierComboBox.SelectedItem;
    }
    private void LoadProduitDataInControls(Produit produit) {
        this.idNumUpDown.Value = produit.Id;
        this.upcCodeNumUpDown.Value = produit.UpcCode;
        this.nameTextBox.Text = produit.Name;
        this.descriptionTextBox.Text = produit.Description;
        this.supplierCodeTextBox.Text = produit.SupplierCode;
        this.AutoCheckBox.Checked = produit.DoAutoRestock;
        this.qtyInStockNumeric.Value = produit.InstockQuantity;
        this.clientComboBox.SelectedItem = produit.ClientsDTO;
        this.supplierComboBox.SelectedItem = produit.SupplierCode;
    }
    private void ValidateFields() {
        if (!Produit.ValiderUPCCode((int) this.upcCodeNumUpDown.Value)) {
            throw new Exception("UPC Code non valide");
        }
        if (string.IsNullOrEmpty(this.nameTextBox.Text)) {
            throw new Exception("Veuillez rentrer un nom valide");
        }
        if (!Produit.ValiderName(this.nameTextBox.Text)) {
            throw new Exception("Le nom de doit pas depasser 128 caractère");
        }
        if (!Produit.ValiderSupplierCode(this.supplierCodeTextBox.Text)) {

            throw new Exception("Le Supplier Code est trop long");
        }
    }
    private void EnableControls() {
        this.idNumUpDown.Enabled = false;
        this.upcCodeNumUpDown.Enabled = true;
        this.nameTextBox.Enabled = true;
        this.descriptionTextBox.Enabled = true;
        this.supplierCodeTextBox.Enabled = true;
        this.AutoCheckBox.Enabled = true;
        this.qtyInStockNumeric.Enabled = true;
        this.clientComboBox.Enabled = true;
        this.supplierComboBox.Enabled = true;
    }
    private void DisableControls() {
        this.idNumUpDown.Enabled = false;
        this.upcCodeNumUpDown.Enabled = false;
        this.nameTextBox.Enabled = false;
        this.descriptionTextBox.Enabled = false;
        this.supplierCodeTextBox.Enabled = false;
        this.AutoCheckBox.Enabled = false;
        this.qtyInStockNumeric.Enabled = false;
        this.clientComboBox.Enabled = false;
        this.supplierComboBox.Enabled = false;

    }
    #endregion
    
    private void CancelBtn_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
    
    private void ActionBtn_Click(object sender, EventArgs e) {

        try {
            switch (this.workingIntent) {
                case ViewIntentEnum.Creation:
                case ViewIntentEnum.Edition:
                    this.SaveDataInInstance();
                    break;
                case ViewIntentEnum.Deletion:
                case ViewIntentEnum.Visualization:
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message);
            return;
        }
    }
}
