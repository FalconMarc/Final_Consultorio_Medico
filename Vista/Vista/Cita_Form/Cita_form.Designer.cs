namespace ConsultorioPrivado.Vista.Cita_Form
{
    partial class Cita_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cita_form));
            resetear_button = new Button();
            nuevo_button = new Button();
            buscar_button = new Button();
            cedula_text = new TextBox();
            label4 = new Label();
            label1 = new Label();
            citas_dgv = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)citas_dgv).BeginInit();
            SuspendLayout();
            // 
            // resetear_button
            // 
            resetear_button.Location = new Point(323, 8);
            resetear_button.Name = "resetear_button";
            resetear_button.Size = new Size(93, 31);
            resetear_button.TabIndex = 29;
            resetear_button.Text = "Resetear";
            resetear_button.UseVisualStyleBackColor = true;
            // 
            // nuevo_button
            // 
            nuevo_button.Location = new Point(8, 55);
            nuevo_button.Name = "nuevo_button";
            nuevo_button.Size = new Size(172, 47);
            nuevo_button.TabIndex = 28;
            nuevo_button.Text = "Nuevo";
            nuevo_button.UseVisualStyleBackColor = true;
            nuevo_button.Click += nuevo_button_Click;
            // 
            // buscar_button
            // 
            buscar_button.Location = new Point(202, 10);
            buscar_button.Name = "buscar_button";
            buscar_button.Size = new Size(96, 29);
            buscar_button.TabIndex = 27;
            buscar_button.Text = "Buscar";
            buscar_button.UseVisualStyleBackColor = true;
            // 
            // cedula_text
            // 
            cedula_text.Location = new Point(80, 14);
            cedula_text.Name = "cedula_text";
            cedula_text.Size = new Size(100, 23);
            cedula_text.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 22);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 25;
            label4.Text = "Cedula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 116);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 24;
            label1.Text = "Citas Agregadas:";
            // 
            // citas_dgv
            // 
            citas_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            citas_dgv.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            citas_dgv.Location = new Point(10, 149);
            citas_dgv.Name = "citas_dgv";
            citas_dgv.RowHeadersWidth = 51;
            citas_dgv.Size = new Size(851, 191);
            citas_dgv.TabIndex = 23;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Editar.HeaderText = "Editar";
            Editar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 43;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 56;
            // 
            // Cita_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 424);
            Controls.Add(resetear_button);
            Controls.Add(nuevo_button);
            Controls.Add(buscar_button);
            Controls.Add(cedula_text);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(citas_dgv);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cita_form";
            Text = "Citas";
            Load += Cita_form_Load;
            ((System.ComponentModel.ISupportInitialize)citas_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetear_button;
        private Button nuevo_button;
        private Button buscar_button;
        private TextBox cedula_text;
        private Label label4;
        private Label label1;
        private DataGridView citas_dgv;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}