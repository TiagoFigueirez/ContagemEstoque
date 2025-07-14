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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.txtCodigoDeBarras = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnGerarRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZerarContagem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvProdutos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(43, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(633, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CONTAGEM DO ESTOQUE";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubTitle.Location = new System.Drawing.Point(67, 113);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(550, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Leia o código do produto com o cursor no campo abaixo";
            // 
            // txtCodigoDeBarras
            // 
            this.txtCodigoDeBarras.Location = new System.Drawing.Point(53, 172);
            this.txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            this.txtCodigoDeBarras.Size = new System.Drawing.Size(611, 43);
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
            this.btnGerarRelatorio.Location = new System.Drawing.Point(53, 259);
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
            // 
            // btnZerarContagem
            // 
            this.btnZerarContagem.Location = new System.Drawing.Point(335, 259);
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
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(53, 347);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(611, 271);
            this.dgvProdutos.StateCommon.Background.Color1 = System.Drawing.Color.LightGray;
            this.dgvProdutos.StateCommon.Background.Color2 = System.Drawing.Color.LightGray;
            this.dgvProdutos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvProdutos.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvProdutos.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvProdutos.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvProdutos.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.LightGray;
            this.dgvProdutos.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvProdutos.StateCommon.DataCell.Border.Rounding = 10;
            this.dgvProdutos.StateCommon.DataCell.Border.Width = 1;
            this.dgvProdutos.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProdutos.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvProdutos.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvProdutos.StateCommon.HeaderColumn.Back.ColorAngle = 90F;
            this.dgvProdutos.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray;
            this.dgvProdutos.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.DimGray;
            this.dgvProdutos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProdutos.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.LightBlue;
            this.dgvProdutos.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.LightBlue;
            this.dgvProdutos.TabIndex = 5;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 665);
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
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvProdutos;
    }
}

