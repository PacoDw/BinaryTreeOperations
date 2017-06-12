namespace BinaryTreeOperations
{
    partial class FormMain
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
            this.txtFraction = new System.Windows.Forms.TextBox();
            this.bttonEvaluar = new System.Windows.Forms.Button();
            this.txtInOrder = new System.Windows.Forms.TextBox();
            this.lblInOrder = new System.Windows.Forms.Label();
            this.txtPreOrder = new System.Windows.Forms.TextBox();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.lblPostOrder = new System.Windows.Forms.Label();
            this.bttonReset = new System.Windows.Forms.Button();
            this.txtResPreOrder = new System.Windows.Forms.TextBox();
            this.txtResPostOrder = new System.Windows.Forms.TextBox();
            this.txtMostrarPila = new System.Windows.Forms.TextBox();
            this.txtMostrarCola = new System.Windows.Forms.TextBox();
            this.lblPila = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFraction
            // 
            this.txtFraction.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraction.Location = new System.Drawing.Point(13, 13);
            this.txtFraction.Name = "txtFraction";
            this.txtFraction.Size = new System.Drawing.Size(246, 23);
            this.txtFraction.TabIndex = 0;
            this.txtFraction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFraction_KeyPress);
            // 
            // bttonEvaluar
            // 
            this.bttonEvaluar.AutoSize = true;
            this.bttonEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonEvaluar.Location = new System.Drawing.Point(276, 11);
            this.bttonEvaluar.Name = "bttonEvaluar";
            this.bttonEvaluar.Size = new System.Drawing.Size(79, 30);
            this.bttonEvaluar.TabIndex = 1;
            this.bttonEvaluar.Text = "Evaluar";
            this.bttonEvaluar.UseVisualStyleBackColor = true;
            this.bttonEvaluar.Click += new System.EventHandler(this.bttonEvaluar_Click);
            // 
            // txtInOrder
            // 
            this.txtInOrder.BackColor = System.Drawing.Color.White;
            this.txtInOrder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInOrder.Location = new System.Drawing.Point(111, 77);
            this.txtInOrder.Name = "txtInOrder";
            this.txtInOrder.ReadOnly = true;
            this.txtInOrder.Size = new System.Drawing.Size(343, 23);
            this.txtInOrder.TabIndex = 0;
            this.txtInOrder.TabStop = false;
            // 
            // lblInOrder
            // 
            this.lblInOrder.AutoSize = true;
            this.lblInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrder.Location = new System.Drawing.Point(9, 80);
            this.lblInOrder.Name = "lblInOrder";
            this.lblInOrder.Size = new System.Drawing.Size(70, 20);
            this.lblInOrder.TabIndex = 0;
            this.lblInOrder.Text = "InOrder";
            // 
            // txtPreOrder
            // 
            this.txtPreOrder.BackColor = System.Drawing.Color.White;
            this.txtPreOrder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreOrder.Location = new System.Drawing.Point(111, 125);
            this.txtPreOrder.Name = "txtPreOrder";
            this.txtPreOrder.ReadOnly = true;
            this.txtPreOrder.Size = new System.Drawing.Size(343, 23);
            this.txtPreOrder.TabIndex = 0;
            this.txtPreOrder.TabStop = false;
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.AutoSize = true;
            this.lblPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrder.Location = new System.Drawing.Point(9, 128);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(81, 20);
            this.lblPreOrder.TabIndex = 0;
            this.lblPreOrder.Text = "PreOrder";
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.BackColor = System.Drawing.Color.White;
            this.txtPostOrder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostOrder.Location = new System.Drawing.Point(111, 173);
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.ReadOnly = true;
            this.txtPostOrder.Size = new System.Drawing.Size(343, 23);
            this.txtPostOrder.TabIndex = 0;
            this.txtPostOrder.TabStop = false;
            // 
            // lblPostOrder
            // 
            this.lblPostOrder.AutoSize = true;
            this.lblPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrder.Location = new System.Drawing.Point(9, 176);
            this.lblPostOrder.Name = "lblPostOrder";
            this.lblPostOrder.Size = new System.Drawing.Size(90, 20);
            this.lblPostOrder.TabIndex = 0;
            this.lblPostOrder.Text = "PostOrder";
            // 
            // bttonReset
            // 
            this.bttonReset.AutoSize = true;
            this.bttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonReset.Location = new System.Drawing.Point(467, 293);
            this.bttonReset.Name = "bttonReset";
            this.bttonReset.Size = new System.Drawing.Size(79, 30);
            this.bttonReset.TabIndex = 2;
            this.bttonReset.Text = "Reset";
            this.bttonReset.UseVisualStyleBackColor = true;
            this.bttonReset.Click += new System.EventHandler(this.bttonReset_Click);
            // 
            // txtResPreOrder
            // 
            this.txtResPreOrder.BackColor = System.Drawing.Color.White;
            this.txtResPreOrder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPreOrder.Location = new System.Drawing.Point(479, 125);
            this.txtResPreOrder.Name = "txtResPreOrder";
            this.txtResPreOrder.ReadOnly = true;
            this.txtResPreOrder.Size = new System.Drawing.Size(67, 23);
            this.txtResPreOrder.TabIndex = 0;
            this.txtResPreOrder.TabStop = false;
            // 
            // txtResPostOrder
            // 
            this.txtResPostOrder.BackColor = System.Drawing.Color.White;
            this.txtResPostOrder.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPostOrder.Location = new System.Drawing.Point(479, 173);
            this.txtResPostOrder.Name = "txtResPostOrder";
            this.txtResPostOrder.ReadOnly = true;
            this.txtResPostOrder.Size = new System.Drawing.Size(67, 23);
            this.txtResPostOrder.TabIndex = 0;
            this.txtResPostOrder.TabStop = false;
            // 
            // txtMostrarPila
            // 
            this.txtMostrarPila.BackColor = System.Drawing.Color.White;
            this.txtMostrarPila.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarPila.Location = new System.Drawing.Point(576, 48);
            this.txtMostrarPila.Multiline = true;
            this.txtMostrarPila.Name = "txtMostrarPila";
            this.txtMostrarPila.ReadOnly = true;
            this.txtMostrarPila.Size = new System.Drawing.Size(82, 285);
            this.txtMostrarPila.TabIndex = 0;
            this.txtMostrarPila.TabStop = false;
            // 
            // txtMostrarCola
            // 
            this.txtMostrarCola.BackColor = System.Drawing.Color.White;
            this.txtMostrarCola.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarCola.Location = new System.Drawing.Point(688, 48);
            this.txtMostrarCola.Multiline = true;
            this.txtMostrarCola.Name = "txtMostrarCola";
            this.txtMostrarCola.ReadOnly = true;
            this.txtMostrarCola.Size = new System.Drawing.Size(82, 285);
            this.txtMostrarCola.TabIndex = 0;
            this.txtMostrarCola.TabStop = false;
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPila.Location = new System.Drawing.Point(572, 5);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(81, 40);
            this.lblPila.TabIndex = 0;
            this.lblPila.Text = "Pila\r\nPreOrder";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCola.Location = new System.Drawing.Point(684, 5);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(90, 40);
            this.lblCola.TabIndex = 0;
            this.lblCola.Text = "Cola\r\nPostOrder";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 345);
            this.Controls.Add(this.lblPostOrder);
            this.Controls.Add(this.lblPreOrder);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.lblInOrder);
            this.Controls.Add(this.bttonReset);
            this.Controls.Add(this.bttonEvaluar);
            this.Controls.Add(this.txtMostrarCola);
            this.Controls.Add(this.txtMostrarPila);
            this.Controls.Add(this.txtPostOrder);
            this.Controls.Add(this.txtPreOrder);
            this.Controls.Add(this.txtResPostOrder);
            this.Controls.Add(this.txtResPreOrder);
            this.Controls.Add(this.txtInOrder);
            this.Controls.Add(this.txtFraction);
            this.Name = "FormMain";
            this.Text = "BinaryTreeOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFraction;
        private System.Windows.Forms.Button bttonEvaluar;
        private System.Windows.Forms.TextBox txtInOrder;
        private System.Windows.Forms.Label lblInOrder;
        private System.Windows.Forms.TextBox txtPreOrder;
        private System.Windows.Forms.Label lblPreOrder;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.Label lblPostOrder;
        private System.Windows.Forms.Button bttonReset;
        private System.Windows.Forms.TextBox txtResPreOrder;
        private System.Windows.Forms.TextBox txtResPostOrder;
        private System.Windows.Forms.TextBox txtMostrarPila;
        private System.Windows.Forms.TextBox txtMostrarCola;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Label lblCola;
    }
}

