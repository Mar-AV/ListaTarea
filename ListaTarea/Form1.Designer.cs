namespace TodoList
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxTarea = new TextBox();
            cbPrioridad = new ComboBox();
            btnAgregar = new Button();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            lblTarea = new Label();
            lblPrioridad = new Label();
            flowPanelTodoList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtBoxTarea
            // 
            txtBoxTarea.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTarea.Location = new Point(48, 64);
            txtBoxTarea.Margin = new Padding(3, 2, 3, 2);
            txtBoxTarea.Name = "txtBoxTarea";
            txtBoxTarea.PlaceholderText = "Indique el nombre de su tarea";
            txtBoxTarea.Size = new Size(482, 22);
            txtBoxTarea.TabIndex = 0;
            // 
            // cbPrioridad
            // 
            cbPrioridad.FormattingEnabled = true;
            cbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cbPrioridad.Location = new Point(539, 39);
            cbPrioridad.Margin = new Padding(3, 2, 3, 2);
            cbPrioridad.Name = "cbPrioridad";
            cbPrioridad.Size = new Size(164, 23);
            cbPrioridad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(720, 38);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += onBtnAgregarClick;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxBuscar.Location = new Point(540, 88);
            txtBoxBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Nombre de la tarea ...";
            txtBoxBuscar.Size = new Size(164, 22);
            txtBoxBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(721, 88);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.BackColor = Color.Transparent;
            lblTarea.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarea.ForeColor = SystemColors.ActiveCaptionText;
            lblTarea.Location = new Point(271, 41);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(44, 16);
            lblTarea.TabIndex = 5;
            lblTarea.Text = "Tarea";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.BackColor = Color.Transparent;
            lblPrioridad.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrioridad.Location = new Point(540, 19);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(66, 17);
            lblPrioridad.TabIndex = 6;
            lblPrioridad.Text = "Prioridad";
            lblPrioridad.Click += lblPrioridad_Click;
            // 
            // flowPanelTodoList
            // 
            flowPanelTodoList.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowPanelTodoList.Location = new Point(24, 117);
            flowPanelTodoList.Margin = new Padding(3, 2, 3, 2);
            flowPanelTodoList.Name = "flowPanelTodoList";
            flowPanelTodoList.Size = new Size(768, 290);
            flowPanelTodoList.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.luxury_white_and_gold_background_with_golden_lines_and_paper_cut_style_premium_gray_and_gold_background_for_award_nomination_ceremony_formal_invitation_or_certificate_design_free_vector;
            ClientSize = new Size(814, 422);
            Controls.Add(flowPanelTodoList);
            Controls.Add(lblPrioridad);
            Controls.Add(lblTarea);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(cbPrioridad);
            Controls.Add(txtBoxTarea);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Padding = new Padding(5, 4, 5, 4);
            Text = "Control de Tareas";
            Load += Form1_Load;
            Click += onBtnAgregarClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxTarea;
		private ComboBox cbPrioridad;
		private Button btnAgregar;
		private TextBox txtBoxBuscar;
		private Button btnBuscar;
		private Label lblTarea;
		private Label lblPrioridad;
		private FlowLayoutPanel flowPanelTodoList;
	}
}
