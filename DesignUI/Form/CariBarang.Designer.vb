<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CariBarang
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
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Kode")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nama")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Harga")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Stok")
        Me.TxtKataKunci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.ListTampil = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'TxtKataKunci
        '
        Me.TxtKataKunci.Location = New System.Drawing.Point(28, 36)
        Me.TxtKataKunci.Name = "TxtKataKunci"
        Me.TxtKataKunci.Size = New System.Drawing.Size(396, 20)
        Me.TxtKataKunci.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kata Kunci"
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(316, 62)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(108, 23)
        Me.BtnCari.TabIndex = 2
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(316, 212)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(108, 23)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'ListTampil
        '
        ListViewItem5.ToolTipText = "Kode"
        ListViewItem6.ToolTipText = "Nama"
        ListViewItem7.ToolTipText = "Harga"
        ListViewItem8.ToolTipText = "Stok"
        Me.ListTampil.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListTampil.Location = New System.Drawing.Point(28, 91)
        Me.ListTampil.Name = "ListTampil"
        Me.ListTampil.Size = New System.Drawing.Size(396, 115)
        Me.ListTampil.TabIndex = 5
        Me.ListTampil.UseCompatibleStateImageBehavior = False
        '
        'CariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 257)
        Me.Controls.Add(Me.ListTampil)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtKataKunci)
        Me.Name = "CariBarang"
        Me.Text = "CariBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKataKunci As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCari As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents ListTampil As ListView
End Class
