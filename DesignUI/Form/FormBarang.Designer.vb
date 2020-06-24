<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtHrgBrg = New System.Windows.Forms.TextBox()
        Me.TxtNmBrg = New System.Windows.Forms.TextBox()
        Me.TxtKdBrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.BtnSelesai = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtStok)
        Me.GroupBox1.Controls.Add(Me.TxtHrgBrg)
        Me.GroupBox1.Controls.Add(Me.TxtNmBrg)
        Me.GroupBox1.Controls.Add(Me.TxtKdBrg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(189, 134)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(261, 20)
        Me.TxtStok.TabIndex = 7
        '
        'TxtHrgBrg
        '
        Me.TxtHrgBrg.Location = New System.Drawing.Point(189, 97)
        Me.TxtHrgBrg.Name = "TxtHrgBrg"
        Me.TxtHrgBrg.Size = New System.Drawing.Size(261, 20)
        Me.TxtHrgBrg.TabIndex = 6
        '
        'TxtNmBrg
        '
        Me.TxtNmBrg.Location = New System.Drawing.Point(189, 64)
        Me.TxtNmBrg.Name = "TxtNmBrg"
        Me.TxtNmBrg.Size = New System.Drawing.Size(261, 20)
        Me.TxtNmBrg.TabIndex = 5
        '
        'TxtKdBrg
        '
        Me.TxtKdBrg.Location = New System.Drawing.Point(189, 31)
        Me.TxtKdBrg.Name = "TxtKdBrg"
        Me.TxtKdBrg.Size = New System.Drawing.Size(261, 20)
        Me.TxtKdBrg.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnSelesai)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnDelete)
        Me.GroupBox2.Controls.Add(Me.BtnUbah)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(475, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(192, 358)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(6, 199)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(178, 36)
        Me.BtnBatal.TabIndex = 4
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(6, 143)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(178, 36)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(6, 254)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(178, 36)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(6, 88)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(178, 36)
        Me.BtnUbah.TabIndex = 1
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(6, 34)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(178, 36)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_barang, Me.nama_barang, Me.harga_satuan, Me.stok})
        Me.DGBarang.Location = New System.Drawing.Point(12, 202)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(457, 158)
        Me.DGBarang.TabIndex = 2
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "kode_barang"
        Me.kode_barang.Name = "kode_barang"
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "nama_barang"
        Me.nama_barang.Name = "nama_barang"
        '
        'harga_satuan
        '
        Me.harga_satuan.HeaderText = "harga_satuan"
        Me.harga_satuan.Name = "harga_satuan"
        '
        'stok
        '
        Me.stok.HeaderText = "stok"
        Me.stok.Name = "stok"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCari)
        Me.GroupBox3.Controls.Add(Me.TxtCari)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 388)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(498, 66)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Data"
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(356, 19)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(136, 20)
        Me.BtnCari.TabIndex = 3
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(9, 19)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(341, 20)
        Me.TxtCari.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnNext)
        Me.GroupBox4.Controls.Add(Me.BtnLast)
        Me.GroupBox4.Controls.Add(Me.BtnPrev)
        Me.GroupBox4.Controls.Add(Me.BtnFirst)
        Me.GroupBox4.Location = New System.Drawing.Point(516, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 65)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(78, 18)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(30, 30)
        Me.BtnNext.TabIndex = 7
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.Location = New System.Drawing.Point(114, 18)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(30, 30)
        Me.BtnLast.TabIndex = 6
        Me.BtnLast.Text = ">>"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Location = New System.Drawing.Point(42, 18)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(30, 30)
        Me.BtnPrev.TabIndex = 5
        Me.BtnPrev.Text = "<"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Location = New System.Drawing.Point(6, 18)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(30, 30)
        Me.BtnFirst.TabIndex = 4
        Me.BtnFirst.Text = "<<"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Location = New System.Drawing.Point(198, 369)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(0, 13)
        Me.LblBaris.TabIndex = 8
        '
        'BtnSelesai
        '
        Me.BtnSelesai.Location = New System.Drawing.Point(6, 311)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(178, 36)
        Me.BtnSelesai.TabIndex = 5
        Me.BtnSelesai.Text = "Selesai"
        Me.BtnSelesai.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 466)
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtHrgBrg As TextBox
    Friend WithEvents TxtNmBrg As TextBox
    Friend WithEvents TxtKdBrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_satuan As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents LblBaris As Label
    Friend WithEvents BtnSelesai As Button
End Class
