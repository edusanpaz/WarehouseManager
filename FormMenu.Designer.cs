namespace WarehouseManager
{
    partial class formMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.buttonNewPurchase = new System.Windows.Forms.Button();
            this.buttonNewSale = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.labelTotalSales = new System.Windows.Forms.Label();
            this.labelTotalPurchases = new System.Windows.Forms.Label();
            this.labelTotalValueVar = new System.Windows.Forms.Label();
            this.labelTotalSalesVar = new System.Windows.Forms.Label();
            this.labelTotalPurchasesVar = new System.Windows.Forms.Label();
            this.labelInfoVar = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewPurchase
            // 
            this.buttonNewPurchase.Location = new System.Drawing.Point(12, 12);
            this.buttonNewPurchase.Name = "buttonNewPurchase";
            this.buttonNewPurchase.Size = new System.Drawing.Size(92, 58);
            this.buttonNewPurchase.TabIndex = 0;
            this.buttonNewPurchase.Text = "Nueva Compra";
            this.buttonNewPurchase.UseVisualStyleBackColor = true;
            this.buttonNewPurchase.Click += new System.EventHandler(this.ButtonNewPurchase_Click);
            // 
            // buttonNewSale
            // 
            this.buttonNewSale.Location = new System.Drawing.Point(110, 12);
            this.buttonNewSale.Name = "buttonNewSale";
            this.buttonNewSale.Size = new System.Drawing.Size(92, 58);
            this.buttonNewSale.TabIndex = 1;
            this.buttonNewSale.Text = "Nueva  Venta";
            this.buttonNewSale.UseVisualStyleBackColor = true;
            this.buttonNewSale.Click += new System.EventHandler(this.ButtonNewSale_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEmployees);
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Location = new System.Drawing.Point(208, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(517, 398);
            this.tabControl.TabIndex = 2;
            // 
            // tabEmployees
            // 
            this.tabEmployees.BackColor = System.Drawing.Color.CadetBlue;
            this.tabEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(509, 372);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Empleados";
            // 
            // tabProducts
            // 
            this.tabProducts.BackColor = System.Drawing.Color.CadetBlue;
            this.tabProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(509, 372);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Productos";
            // 
            // tabClients
            // 
            this.tabClients.BackColor = System.Drawing.Color.CadetBlue;
            this.tabClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Size = new System.Drawing.Size(509, 372);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Clientes";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelInfo.Location = new System.Drawing.Point(44, 95);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(122, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Información del almacén";
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Location = new System.Drawing.Point(9, 127);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(65, 13);
            this.labelTotalValue.TabIndex = 4;
            this.labelTotalValue.Text = "Valor total";
            // 
            // labelTotalSales
            // 
            this.labelTotalSales.AutoSize = true;
            this.labelTotalSales.Location = new System.Drawing.Point(9, 172);
            this.labelTotalSales.Name = "labelTotalSales";
            this.labelTotalSales.Size = new System.Drawing.Size(46, 13);
            this.labelTotalSales.TabIndex = 5;
            this.labelTotalSales.Text = "Ventas";
            // 
            // labelTotalPurchases
            // 
            this.labelTotalPurchases.AutoSize = true;
            this.labelTotalPurchases.Location = new System.Drawing.Point(9, 216);
            this.labelTotalPurchases.Name = "labelTotalPurchases";
            this.labelTotalPurchases.Size = new System.Drawing.Size(55, 13);
            this.labelTotalPurchases.TabIndex = 6;
            this.labelTotalPurchases.Text = "Compras";
            // 
            // labelTotalValueVar
            // 
            this.labelTotalValueVar.AutoSize = true;
            this.labelTotalValueVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValueVar.Location = new System.Drawing.Point(9, 150);
            this.labelTotalValueVar.Name = "labelTotalValueVar";
            this.labelTotalValueVar.Size = new System.Drawing.Size(13, 13);
            this.labelTotalValueVar.TabIndex = 7;
            this.labelTotalValueVar.Text = "0";
            // 
            // labelTotalSalesVar
            // 
            this.labelTotalSalesVar.AutoSize = true;
            this.labelTotalSalesVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSalesVar.Location = new System.Drawing.Point(9, 194);
            this.labelTotalSalesVar.Name = "labelTotalSalesVar";
            this.labelTotalSalesVar.Size = new System.Drawing.Size(13, 13);
            this.labelTotalSalesVar.TabIndex = 8;
            this.labelTotalSalesVar.Text = "0";
            // 
            // labelTotalPurchasesVar
            // 
            this.labelTotalPurchasesVar.AutoSize = true;
            this.labelTotalPurchasesVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPurchasesVar.Location = new System.Drawing.Point(9, 240);
            this.labelTotalPurchasesVar.Name = "labelTotalPurchasesVar";
            this.labelTotalPurchasesVar.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPurchasesVar.TabIndex = 9;
            this.labelTotalPurchasesVar.Text = "0";
            // 
            // labelInfoVar
            // 
            this.labelInfoVar.AutoSize = true;
            this.labelInfoVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoVar.Location = new System.Drawing.Point(12, 302);
            this.labelInfoVar.Name = "labelInfoVar";
            this.labelInfoVar.Size = new System.Drawing.Size(61, 13);
            this.labelInfoVar.TabIndex = 10;
            this.labelInfoVar.Text = "Benvenido.";
            this.labelInfoVar.Click += new System.EventHandler(this.LabelInfoVar_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 436);
            this.Controls.Add(this.labelInfoVar);
            this.Controls.Add(this.labelTotalPurchasesVar);
            this.Controls.Add(this.labelTotalSalesVar);
            this.Controls.Add(this.labelTotalValueVar);
            this.Controls.Add(this.labelTotalPurchases);
            this.Controls.Add(this.labelTotalSales);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonNewSale);
            this.Controls.Add(this.buttonNewPurchase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseManager";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewPurchase;
        private System.Windows.Forms.Button buttonNewSale;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Label labelTotalSales;
        private System.Windows.Forms.Label labelTotalPurchases;
        private System.Windows.Forms.Label labelTotalValueVar;
        private System.Windows.Forms.Label labelTotalSalesVar;
        private System.Windows.Forms.Label labelTotalPurchasesVar;
        private System.Windows.Forms.Label labelInfoVar;
        private System.Windows.Forms.TabPage tabClients;
    }
}

