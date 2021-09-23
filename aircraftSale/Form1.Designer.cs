
namespace aircraftSale
{
    partial class FormAircraft
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAircraft = new System.Windows.Forms.TextBox();
            this.textBoxManufacturing = new System.Windows.Forms.TextBox();
            this.textBoxTurbulence = new System.Windows.Forms.TextBox();
            this.textBoxPassenger = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurbulence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger Capacity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wake Turbulence:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxAircraft
            // 
            this.textBoxAircraft.Location = new System.Drawing.Point(81, 42);
            this.textBoxAircraft.Name = "textBoxAircraft";
            this.textBoxAircraft.Size = new System.Drawing.Size(100, 20);
            this.textBoxAircraft.TabIndex = 4;
            // 
            // textBoxManufacturing
            // 
            this.textBoxManufacturing.Location = new System.Drawing.Point(275, 42);
            this.textBoxManufacturing.Name = "textBoxManufacturing";
            this.textBoxManufacturing.Size = new System.Drawing.Size(100, 20);
            this.textBoxManufacturing.TabIndex = 5;
            // 
            // textBoxTurbulence
            // 
            this.textBoxTurbulence.Location = new System.Drawing.Point(490, 42);
            this.textBoxTurbulence.Name = "textBoxTurbulence";
            this.textBoxTurbulence.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurbulence.TabIndex = 6;
            // 
            // textBoxPassenger
            // 
            this.textBoxPassenger.Location = new System.Drawing.Point(714, 42);
            this.textBoxPassenger.Name = "textBoxPassenger";
            this.textBoxPassenger.Size = new System.Drawing.Size(53, 20);
            this.textBoxPassenger.TabIndex = 7;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(40, 86);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Clean";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colManufacturing,
            this.colTurbulence,
            this.colPassenger});
            this.dataGridInventory.Location = new System.Drawing.Point(124, 138);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.Size = new System.Drawing.Size(544, 255);
            this.dataGridInventory.TabIndex = 9;
            this.dataGridInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "Id";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colManufacturing
            // 
            this.colManufacturing.HeaderText = "Manufacturing";
            this.colManufacturing.Name = "colManufacturing";
            // 
            // colTurbulence
            // 
            this.colTurbulence.HeaderText = "Wake Turbulence";
            this.colTurbulence.Name = "colTurbulence";
            // 
            // colPassenger
            // 
            this.colPassenger.HeaderText = "Passenger Capacity";
            this.colPassenger.Name = "colPassenger";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(124, 86);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridInventory);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.textBoxPassenger);
            this.Controls.Add(this.textBoxTurbulence);
            this.Controls.Add(this.textBoxManufacturing);
            this.Controls.Add(this.textBoxAircraft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAircraft";
            this.Text = "Aircraft Sales";
            this.Load += new System.EventHandler(this.FormAircraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAircraft;
        private System.Windows.Forms.TextBox textBoxManufacturing;
        private System.Windows.Forms.TextBox textBoxTurbulence;
        private System.Windows.Forms.TextBox textBoxPassenger;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurbulence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassenger;
        private System.Windows.Forms.Button buttonInsert;
    }
}

