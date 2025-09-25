namespace ContagemEstoque
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.txtCodigoDeBarras = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnGerarRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZerarContagem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnIncluirContagemSalva = new System.Windows.Forms.Button();
            this.btnSalvarRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadFrmFilePathSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Border.Rounding = 5000;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 9;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(588, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CONTAGEM DO ESTOQUE";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitle.Location = new System.Drawing.Point(15, 121);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(540, 30);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Leia o código do produto com o cursor no campo abaixo";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(9, 172);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(567, 43);
            this.txtCodigoDeBarras.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.txtCodigoDeBarras.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.txtCodigoDeBarras.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCodigoDeBarras.StateActive.Border.Rounding = 10;
            this.txtCodigoDeBarras.StateActive.Border.Width = 2;
            this.txtCodigoDeBarras.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCodigoDeBarras.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.txtCodigoDeBarras.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.txtCodigoDeBarras.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCodigoDeBarras.StateCommon.Border.Rounding = 10;
            this.txtCodigoDeBarras.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtCodigoDeBarras.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeBarras.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCodigoDeBarras.StateDisabled.Border.Rounding = 10;
            this.txtCodigoDeBarras.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.txtCodigoDeBarras.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.txtCodigoDeBarras.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCodigoDeBarras.StateNormal.Border.Rounding = 10;
            this.txtCodigoDeBarras.TabIndex = 2;
            this.txtCodigoDeBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LerCodigoBarras);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(20, 237);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.OverrideDefault.Back.ColorAngle = 5F;
            this.btnGerarRelatorio.Size = new System.Drawing.Size(192, 53);
            this.btnGerarRelatorio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateCommon.Back.ColorAngle = 5F;
            this.btnGerarRelatorio.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnGerarRelatorio.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StateCommon.Border.Rounding = 20;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateDisabled.Back.ColorAngle = 5F;
            this.btnGerarRelatorio.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StateDisabled.Border.Rounding = 20;
            this.btnGerarRelatorio.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateNormal.Back.ColorAngle = 5F;
            this.btnGerarRelatorio.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StatePressed.Back.ColorAngle = 5F;
            this.btnGerarRelatorio.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StatePressed.Border.Rounding = 20;
            this.btnGerarRelatorio.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnGerarRelatorio.StateTracking.Back.ColorAngle = 5F;
            this.btnGerarRelatorio.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StateTracking.Border.Rounding = 20;
            this.btnGerarRelatorio.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGerarRelatorio.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGerarRelatorio.TabIndex = 3;
            this.btnGerarRelatorio.Values.Text = "GERAR RELATÓRIO";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.GerarRelatorio);
            // 
            // btnZerarContagem
            // 
            this.btnZerarContagem.Location = new System.Drawing.Point(296, 237);
            this.btnZerarContagem.Name = "btnZerarContagem";
            this.btnZerarContagem.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnZerarContagem.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnZerarContagem.OverrideDefault.Back.ColorAngle = 5F;
            this.btnZerarContagem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.OverrideDefault.Border.ColorAngle = 5F;
            this.btnZerarContagem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnZerarContagem.OverrideDefault.Border.Rounding = 20;
            this.btnZerarContagem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.OverrideDefault.Content.ShortText.ColorAngle = 5F;
            this.btnZerarContagem.Size = new System.Drawing.Size(192, 53);
            this.btnZerarContagem.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnZerarContagem.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnZerarContagem.StateCommon.Back.ColorAngle = 5F;
            this.btnZerarContagem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateCommon.Border.ColorAngle = 5F;
            this.btnZerarContagem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnZerarContagem.StateCommon.Border.Rounding = 20;
            this.btnZerarContagem.StateCommon.Border.Width = 3;
            this.btnZerarContagem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateCommon.Content.ShortText.ColorAngle = 5F;
            this.btnZerarContagem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerarContagem.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnZerarContagem.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnZerarContagem.StateDisabled.Back.ColorAngle = 5F;
            this.btnZerarContagem.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateDisabled.Border.ColorAngle = 5F;
            this.btnZerarContagem.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnZerarContagem.StateDisabled.Border.Rounding = 20;
            this.btnZerarContagem.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateDisabled.Content.ShortText.ColorAngle = 5F;
            this.btnZerarContagem.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerarContagem.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnZerarContagem.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnZerarContagem.StateNormal.Back.ColorAngle = 5F;
            this.btnZerarContagem.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateNormal.Border.ColorAngle = 5F;
            this.btnZerarContagem.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnZerarContagem.StateNormal.Border.Rounding = 20;
            this.btnZerarContagem.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateNormal.Content.ShortText.ColorAngle = 5F;
            this.btnZerarContagem.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerarContagem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StatePressed.Back.ColorAngle = 5F;
            this.btnZerarContagem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnZerarContagem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnZerarContagem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnZerarContagem.TabIndex = 4;
            this.btnZerarContagem.Values.Text = "ZERAR CONTAGEM";
            this.btnZerarContagem.Click += new System.EventHandler(this.ZerarContagem);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeight = 54;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.Snow;
            this.dgvProdutos.Location = new System.Drawing.Point(18, 316);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(570, 282);
            this.dgvProdutos.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(31, 612);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnExcluir.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnExcluir.OverrideDefault.Back.ColorAngle = 5F;
            this.btnExcluir.Size = new System.Drawing.Size(192, 53);
            this.btnExcluir.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateCommon.Back.ColorAngle = 5F;
            this.btnExcluir.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnExcluir.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluir.StateCommon.Border.Rounding = 20;
            this.btnExcluir.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcluir.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExcluir.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateDisabled.Back.ColorAngle = 5F;
            this.btnExcluir.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluir.StateDisabled.Border.Rounding = 20;
            this.btnExcluir.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateNormal.Back.ColorAngle = 5F;
            this.btnExcluir.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnExcluir.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnExcluir.StatePressed.Back.ColorAngle = 5F;
            this.btnExcluir.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluir.StatePressed.Border.Rounding = 20;
            this.btnExcluir.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcluir.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExcluir.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(38)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(127)))));
            this.btnExcluir.StateTracking.Back.ColorAngle = 5F;
            this.btnExcluir.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluir.StateTracking.Border.Rounding = 20;
            this.btnExcluir.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcluir.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Values.Text = "EXCLUIR PRODUTO";
            this.btnExcluir.Click += new System.EventHandler(this.ExcluirProduto);
            // 
            // btnIncluirContagemSalva
            // 
            this.btnIncluirContagemSalva.FlatAppearance.BorderSize = 0;
            this.btnIncluirContagemSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirContagemSalva.Image = global::ContagemEstoque.Properties.Resources.icons8_download_48;
            this.btnIncluirContagemSalva.Location = new System.Drawing.Point(1064, 3);
            this.btnIncluirContagemSalva.Name = "btnIncluirContagemSalva";
            this.btnIncluirContagemSalva.Size = new System.Drawing.Size(46, 36);
            this.btnIncluirContagemSalva.TabIndex = 10;
            this.btnIncluirContagemSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnIncluirContagemSalva.UseVisualStyleBackColor = true;
            this.btnIncluirContagemSalva.Click += new System.EventHandler(this.IncluirContagemSalva);
            // 
            // btnSalvarRelatorio
            // 
            this.btnSalvarRelatorio.FlatAppearance.BorderSize = 0;
            this.btnSalvarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRelatorio.Image = global::ContagemEstoque.Properties.Resources.icons8_save_30;
            this.btnSalvarRelatorio.Location = new System.Drawing.Point(1106, 0);
            this.btnSalvarRelatorio.Name = "btnSalvarRelatorio";
            this.btnSalvarRelatorio.Size = new System.Drawing.Size(46, 36);
            this.btnSalvarRelatorio.TabIndex = 9;
            this.btnSalvarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSalvarRelatorio.UseVisualStyleBackColor = true;
            this.btnSalvarRelatorio.Click += new System.EventHandler(this.SalvarContagem);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContagemEstoque.Properties.Resources.Checking_boxes_amico;
            this.pictureBox1.Location = new System.Drawing.Point(591, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btnLoadFrmFilePathSave
            // 
            this.btnLoadFrmFilePathSave.FlatAppearance.BorderSize = 0;
            this.btnLoadFrmFilePathSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFrmFilePathSave.Image = global::ContagemEstoque.Properties.Resources.fileIcon;
            this.btnLoadFrmFilePathSave.Location = new System.Drawing.Point(1145, 0);
            this.btnLoadFrmFilePathSave.Name = "btnLoadFrmFilePathSave";
            this.btnLoadFrmFilePathSave.Size = new System.Drawing.Size(46, 36);
            this.btnLoadFrmFilePathSave.TabIndex = 7;
            this.btnLoadFrmFilePathSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLoadFrmFilePathSave.UseVisualStyleBackColor = true;
            this.btnLoadFrmFilePathSave.Click += new System.EventHandler(this.AbrirFrmFilePathSave);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 665);
            this.Controls.Add(this.btnIncluirContagemSalva);
            this.Controls.Add(this.btnSalvarRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadFrmFilePathSave);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnZerarContagem);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.txtCodigoDeBarras);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Border.Rounding = 10;
            this.Text = "Contagem Estoque";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCodigoDeBarras;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGerarRelatorio;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZerarContagem;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExcluir;
        private System.Windows.Forms.Button btnLoadFrmFilePathSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvarRelatorio;
        private System.Windows.Forms.Button btnIncluirContagemSalva;
    }
}

