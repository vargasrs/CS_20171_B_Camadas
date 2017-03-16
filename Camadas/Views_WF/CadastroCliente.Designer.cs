namespace Views_WF
{
  partial class CadastroCliente
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
      this.lblID = new System.Windows.Forms.Label();
      this.lblNome = new System.Windows.Forms.Label();
      this.lblcpf = new System.Windows.Forms.Label();
      this.txtid = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.txtcpf = new System.Windows.Forms.TextBox();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.Location = new System.Drawing.Point(27, 32);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(18, 13);
      this.lblID.TabIndex = 0;
      this.lblID.Text = "ID";
      this.lblID.Click += new System.EventHandler(this.label1_Click);
      // 
      // lblNome
      // 
      this.lblNome.AutoSize = true;
      this.lblNome.Location = new System.Drawing.Point(27, 62);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(35, 13);
      this.lblNome.TabIndex = 1;
      this.lblNome.Text = "Nome";
      // 
      // lblcpf
      // 
      this.lblcpf.AutoSize = true;
      this.lblcpf.Location = new System.Drawing.Point(27, 87);
      this.lblcpf.Name = "lblcpf";
      this.lblcpf.Size = new System.Drawing.Size(27, 13);
      this.lblcpf.TabIndex = 2;
      this.lblcpf.Text = "CPF";
      // 
      // txtid
      // 
      this.txtid.Location = new System.Drawing.Point(96, 25);
      this.txtid.Name = "txtid";
      this.txtid.Size = new System.Drawing.Size(47, 20);
      this.txtid.TabIndex = 3;
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(96, 55);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(224, 20);
      this.txtNome.TabIndex = 4;
      // 
      // txtcpf
      // 
      this.txtcpf.Location = new System.Drawing.Point(96, 84);
      this.txtcpf.Name = "txtcpf";
      this.txtcpf.Size = new System.Drawing.Size(129, 20);
      this.txtcpf.TabIndex = 5;
      // 
      // btnSalvar
      // 
      this.btnSalvar.Location = new System.Drawing.Point(164, 145);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(75, 23);
      this.btnSalvar.TabIndex = 6;
      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(245, 145);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 7;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // CadastroCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(341, 213);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.txtcpf);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.txtid);
      this.Controls.Add(this.lblcpf);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.lblID);
      this.Name = "CadastroCliente";
      this.Text = "Cadastro Cliente";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.Label lblNome;
    private System.Windows.Forms.Label lblcpf;
    private System.Windows.Forms.TextBox txtid;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.TextBox txtcpf;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnCancelar;
  }
}