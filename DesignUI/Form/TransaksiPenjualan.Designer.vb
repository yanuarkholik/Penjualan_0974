<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtTgl = New System.Windows.Forms.Label()
        Me.Nota = New System.Windows.Forms.Label()
        Me.TxtTanggal = New System.Windows.Forms.TextBox()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtNmKasir = New System.Windows.Forms.TextBox()
        Me.TxtKasir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBanyak = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPotongan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalBersih = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtKembali = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtTgl
        '
        Me.TxtTgl.AutoSize = True
        Me.TxtTgl.Location = New System.Drawing.Point(9, 48)
        Me.TxtTgl.Name = "TxtTgl"
        Me.TxtTgl.Size = New System.Drawing.Size(46, 13)
        Me.TxtTgl.TabIndex = 0
        Me.TxtTgl.Text = "Tanggal"
        '
        'Nota
        '
        Me.Nota.AutoSize = True
        Me.Nota.Location = New System.Drawing.Point(9, 93)
        Me.Nota.Name = "Nota"
        Me.Nota.Size = New System.Drawing.Size(30, 13)
        Me.Nota.TabIndex = 1
        Me.Nota.Text = "Nota"
        '
        'TxtTanggal
        '
        Me.TxtTanggal.Location = New System.Drawing.Point(12, 64)
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Size = New System.Drawing.Size(209, 20)
        Me.TxtTanggal.TabIndex = 2
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(12, 109)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(209, 20)
        Me.TxtNota.TabIndex = 3
        '
        'TxtNmKasir
        '
        Me.TxtNmKasir.Location = New System.Drawing.Point(248, 109)
        Me.TxtNmKasir.Name = "TxtNmKasir"
        Me.TxtNmKasir.Size = New System.Drawing.Size(209, 20)
        Me.TxtNmKasir.TabIndex = 7
        '
        'TxtKasir
        '
        Me.TxtKasir.Location = New System.Drawing.Point(248, 64)
        Me.TxtKasir.Name = "TxtKasir"
        Me.TxtKasir.Size = New System.Drawing.Size(209, 20)
        Me.TxtKasir.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Kasir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kasir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtBanyak)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtKode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 279)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(20, 40)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(121, 20)
        Me.TxtKode.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Kode"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(196, 40)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(121, 20)
        Me.TxtNama.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nama"
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(323, 40)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(121, 20)
        Me.TxtHarga.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(320, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga"
        '
        'TxtBanyak
        '
        Me.TxtBanyak.Location = New System.Drawing.Point(450, 41)
        Me.TxtBanyak.Name = "TxtBanyak"
        Me.TxtBanyak.Size = New System.Drawing.Size(121, 20)
        Me.TxtBanyak.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Banyak"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ". . . ."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPotongan
        '
        Me.TxtPotongan.Location = New System.Drawing.Point(110, 437)
        Me.TxtPotongan.Name = "TxtPotongan"
        Me.TxtPotongan.Size = New System.Drawing.Size(253, 20)
        Me.TxtPotongan.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 440)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Potongan"
        '
        'TxtTotalBersih
        '
        Me.TxtTotalBersih.Location = New System.Drawing.Point(110, 463)
        Me.TxtTotalBersih.Name = "TxtTotalBersih"
        Me.TxtTotalBersih.Size = New System.Drawing.Size(253, 20)
        Me.TxtTotalBersih.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total Bersih"
        '
        'TxtBayar
        '
        Me.TxtBayar.Location = New System.Drawing.Point(110, 489)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(253, 20)
        Me.TxtBayar.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 492)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Bayar"
        '
        'TxtKembali
        '
        Me.TxtKembali.Location = New System.Drawing.Point(110, 515)
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(253, 20)
        Me.TxtKembali.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 518)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Kembali"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(369, 434)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 25)
        Me.BtnTambah.TabIndex = 18
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(450, 434)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 25)
        Me.BtnSimpan.TabIndex = 26
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(531, 433)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 25)
        Me.BtnTutup.TabIndex = 27
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(20, 67)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(551, 183)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Jumlah Barang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(132, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Label"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(318, 253)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total Belanja"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(435, 253)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Label"
        '
        'TransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 556)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtKembali)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtBayar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTotalBersih)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPotongan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNmKasir)
        Me.Controls.Add(Me.TxtKasir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.TxtTanggal)
        Me.Controls.Add(Me.Nota)
        Me.Controls.Add(Me.TxtTgl)
        Me.Name = "TransaksiPenjualan"
        Me.Text = "TransaksiPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTgl As Label
    Friend WithEvents Nota As Label
    Friend WithEvents TxtTanggal As TextBox
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents TxtNmKasir As TextBox
    Friend WithEvents TxtKasir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtBanyak As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TxtPotongan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalBersih As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBayar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtKembali As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnTutup As Button
End Class
