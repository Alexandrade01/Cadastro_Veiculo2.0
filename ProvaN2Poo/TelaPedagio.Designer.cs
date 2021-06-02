
namespace ProvaN2Poo
{
    partial class TelaPedagio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedagio));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndentificacao = new System.Windows.Forms.TextBox();
            this.gbPedagio = new System.Windows.Forms.GroupBox();
            this.BtnPagarTodos = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.cbCidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbPedagio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificação";
            // 
            // txtIndentificacao
            // 
            this.txtIndentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndentificacao.Location = new System.Drawing.Point(142, 32);
            this.txtIndentificacao.Name = "txtIndentificacao";
            this.txtIndentificacao.Size = new System.Drawing.Size(152, 29);
            this.txtIndentificacao.TabIndex = 3;
            // 
            // gbPedagio
            // 
            this.gbPedagio.Controls.Add(this.BtnPagarTodos);
            this.gbPedagio.Controls.Add(this.BtnRelatorio);
            this.gbPedagio.Controls.Add(this.BtnTotal);
            this.gbPedagio.Controls.Add(this.BtnReceber);
            this.gbPedagio.Controls.Add(this.cbCidades);
            this.gbPedagio.Controls.Add(this.label2);
            this.gbPedagio.Location = new System.Drawing.Point(22, 179);
            this.gbPedagio.Name = "gbPedagio";
            this.gbPedagio.Size = new System.Drawing.Size(314, 350);
            this.gbPedagio.TabIndex = 4;
            this.gbPedagio.TabStop = false;
            // 
            // BtnPagarTodos
            // 
            this.BtnPagarTodos.BackColor = System.Drawing.Color.Silver;
            this.BtnPagarTodos.Font = new System.Drawing.Font("Impact", 12F);
            this.BtnPagarTodos.Location = new System.Drawing.Point(22, 282);
            this.BtnPagarTodos.Name = "BtnPagarTodos";
            this.BtnPagarTodos.Size = new System.Drawing.Size(281, 38);
            this.BtnPagarTodos.TabIndex = 26;
            this.BtnPagarTodos.Text = "Pagar Pedagio com todos os veiculos";
            this.BtnPagarTodos.UseVisualStyleBackColor = false;
            this.BtnPagarTodos.Click += new System.EventHandler(this.BtnPagarTodos_Click);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.BackColor = System.Drawing.Color.Silver;
            this.BtnRelatorio.Font = new System.Drawing.Font("Impact", 12F);
            this.BtnRelatorio.Location = new System.Drawing.Point(22, 215);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(281, 38);
            this.BtnRelatorio.TabIndex = 25;
            this.BtnRelatorio.Text = "Relatorio total de Pedagios recebidos ";
            this.BtnRelatorio.UseVisualStyleBackColor = false;
            this.BtnRelatorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTotal
            // 
            this.BtnTotal.BackColor = System.Drawing.Color.Silver;
            this.BtnTotal.Font = new System.Drawing.Font("Impact", 12F);
            this.BtnTotal.Location = new System.Drawing.Point(22, 146);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(281, 38);
            this.BtnTotal.TabIndex = 24;
            this.BtnTotal.Text = "Valor total de Pedagios recebidos ";
            this.BtnTotal.UseVisualStyleBackColor = false;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // BtnReceber
            // 
            this.BtnReceber.BackColor = System.Drawing.Color.Silver;
            this.BtnReceber.Font = new System.Drawing.Font("Impact", 12F);
            this.BtnReceber.Location = new System.Drawing.Point(22, 78);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(281, 38);
            this.BtnReceber.TabIndex = 23;
            this.BtnReceber.Text = "Receber Pedagio";
            this.BtnReceber.UseVisualStyleBackColor = false;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // cbCidades
            // 
            this.cbCidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidades.FormattingEnabled = true;
            this.cbCidades.Items.AddRange(new object[] {
            "São Paulo - SP",
            "Maua - SP",
            "Santo André - SP",
            "São Caetano - SP",
            "São Bernardo do Campo - SP",
            "Diadema - SP",
            "Santos - SP",
            "Rio de Janeiro - RJ",
            "Belo Horizonte - MG",
            "Curitiba - PR",
            "Porto Alegre - RS",
            "Vitória - ES"});
            this.cbCidades.Location = new System.Drawing.Point(143, 28);
            this.cbCidades.Name = "cbCidades";
            this.cbCidades.Size = new System.Drawing.Size(151, 21);
            this.cbCidades.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Localização";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Silver;
            this.BtnPesquisar.Font = new System.Drawing.Font("Impact", 12F);
            this.BtnPesquisar.Location = new System.Drawing.Point(13, 81);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(281, 38);
            this.BtnPesquisar.TabIndex = 25;
            this.BtnPesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.BtnPesquisar, "Pesquise antes de cobrar o pedagio!");
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Italic);
            this.textBox1.Location = new System.Drawing.Point(403, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(437, 517);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnPesquisar);
            this.groupBox2.Controls.Add(this.txtIndentificacao);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 151);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // TelaPedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(884, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbPedagio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 768);
            this.Name = "TelaPedagio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPedagio";
            this.gbPedagio.ResumeLayout(false);
            this.gbPedagio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndentificacao;
        private System.Windows.Forms.GroupBox gbPedagio;
        private System.Windows.Forms.ComboBox cbCidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRelatorio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnPagarTodos;
    }
}