<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMahasiswa
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
        Me.cjurusan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tnotel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tnim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BersihBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.dgvmahasiswa = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ctahunajaran = New System.Windows.Forms.ComboBox()
        Me.cjenjangstudi = New System.Windows.Forms.ComboBox()
        Me.dtlahir = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ttempat = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CariBtn = New System.Windows.Forms.Button()
        Me.tkata = New System.Windows.Forms.TextBox()
        Me.rbtNim = New System.Windows.Forms.RadioButton()
        Me.rbtNama = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvmahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cjurusan
        '
        Me.cjurusan.FormattingEnabled = True
        Me.cjurusan.Items.AddRange(New Object() {"Sistem Informasi", "Sistem Komputer", "Teknik Komputer", "Manajemen Informatika"})
        Me.cjurusan.Location = New System.Drawing.Point(199, 119)
        Me.cjurusan.Name = "cjurusan"
        Me.cjurusan.Size = New System.Drawing.Size(245, 21)
        Me.cjurusan.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'tnotel
        '
        Me.tnotel.Location = New System.Drawing.Point(199, 224)
        Me.tnotel.Name = "tnotel"
        Me.tnotel.Size = New System.Drawing.Size(245, 20)
        Me.tnotel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat / Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenjang Studi"
        '
        'tnama
        '
        Me.tnama.Location = New System.Drawing.Point(199, 48)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(245, 20)
        Me.tnama.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tahun Ajaran"
        '
        'tnim
        '
        Me.tnim.Location = New System.Drawing.Point(199, 19)
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(245, 20)
        Me.tnim.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No. Telpon"
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(106, 19)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 23)
        Me.UbahBtn.TabIndex = 9
        Me.UbahBtn.Text = "UBAH"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(6, 19)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 23)
        Me.SimpanBtn.TabIndex = 8
        Me.SimpanBtn.Text = "SIMPAN"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TutupBtn)
        Me.GroupBox2.Controls.Add(Me.BersihBtn)
        Me.GroupBox2.Controls.Add(Me.HapusBtn)
        Me.GroupBox2.Controls.Add(Me.UbahBtn)
        Me.GroupBox2.Controls.Add(Me.SimpanBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 54)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(424, 19)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 14
        Me.TutupBtn.Text = "TUTUP"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BersihBtn
        '
        Me.BersihBtn.Location = New System.Drawing.Point(316, 19)
        Me.BersihBtn.Name = "BersihBtn"
        Me.BersihBtn.Size = New System.Drawing.Size(75, 23)
        Me.BersihBtn.TabIndex = 12
        Me.BersihBtn.Text = "BERSIH"
        Me.BersihBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(214, 19)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusBtn.TabIndex = 10
        Me.HapusBtn.Text = "HAPUS"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'dgvmahasiswa
        '
        Me.dgvmahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmahasiswa.Location = New System.Drawing.Point(7, 379)
        Me.dgvmahasiswa.Name = "dgvmahasiswa"
        Me.dgvmahasiswa.Size = New System.Drawing.Size(516, 162)
        Me.dgvmahasiswa.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ctahunajaran)
        Me.GroupBox1.Controls.Add(Me.cjenjangstudi)
        Me.GroupBox1.Controls.Add(Me.dtlahir)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ttempat)
        Me.GroupBox1.Controls.Add(Me.cjurusan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tnotel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tnama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tnim)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 265)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'ctahunajaran
        '
        Me.ctahunajaran.FormattingEnabled = True
        Me.ctahunajaran.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026"})
        Me.ctahunajaran.Location = New System.Drawing.Point(199, 194)
        Me.ctahunajaran.Name = "ctahunajaran"
        Me.ctahunajaran.Size = New System.Drawing.Size(245, 21)
        Me.ctahunajaran.TabIndex = 12
        '
        'cjenjangstudi
        '
        Me.cjenjangstudi.FormattingEnabled = True
        Me.cjenjangstudi.Items.AddRange(New Object() {"D3", "S1", "S2", "S3"})
        Me.cjenjangstudi.Location = New System.Drawing.Point(199, 156)
        Me.cjenjangstudi.Name = "cjenjangstudi"
        Me.cjenjangstudi.Size = New System.Drawing.Size(245, 21)
        Me.cjenjangstudi.TabIndex = 11
        '
        'dtlahir
        '
        Me.dtlahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtlahir.Location = New System.Drawing.Point(327, 84)
        Me.dtlahir.Name = "dtlahir"
        Me.dtlahir.Size = New System.Drawing.Size(117, 20)
        Me.dtlahir.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(312, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "/"
        '
        'ttempat
        '
        Me.ttempat.Location = New System.Drawing.Point(199, 84)
        Me.ttempat.Name = "ttempat"
        Me.ttempat.Size = New System.Drawing.Size(107, 20)
        Me.ttempat.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.rbtNama)
        Me.GroupBox3.Controls.Add(Me.rbtNim)
        Me.GroupBox3.Controls.Add(Me.tkata)
        Me.GroupBox3.Controls.Add(Me.CariBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(516, 54)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian"
        '
        'CariBtn
        '
        Me.CariBtn.Location = New System.Drawing.Point(424, 19)
        Me.CariBtn.Name = "CariBtn"
        Me.CariBtn.Size = New System.Drawing.Size(75, 23)
        Me.CariBtn.TabIndex = 14
        Me.CariBtn.Text = "CARI"
        Me.CariBtn.UseVisualStyleBackColor = True
        '
        'tkata
        '
        Me.tkata.Location = New System.Drawing.Point(173, 21)
        Me.tkata.Name = "tkata"
        Me.tkata.Size = New System.Drawing.Size(245, 20)
        Me.tkata.TabIndex = 13
        '
        'rbtNim
        '
        Me.rbtNim.AutoSize = True
        Me.rbtNim.Location = New System.Drawing.Point(34, 13)
        Me.rbtNim.Name = "rbtNim"
        Me.rbtNim.Size = New System.Drawing.Size(45, 17)
        Me.rbtNim.TabIndex = 15
        Me.rbtNim.TabStop = True
        Me.rbtNim.Text = "NIM"
        Me.rbtNim.UseVisualStyleBackColor = True
        '
        'rbtNama
        '
        Me.rbtNama.AutoSize = True
        Me.rbtNama.Location = New System.Drawing.Point(34, 31)
        Me.rbtNama.Name = "rbtNama"
        Me.rbtNama.Size = New System.Drawing.Size(53, 17)
        Me.rbtNama.TabIndex = 16
        Me.rbtNama.TabStop = True
        Me.rbtNama.Text = "Nama"
        Me.rbtNama.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(138, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Kata"
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 551)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvmahasiswa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormMahasiswa"
        Me.Text = "FormMahasiswa"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvmahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cjurusan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tnotel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tnama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tnim As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UbahBtn As Button
    Friend WithEvents SimpanBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TutupBtn As Button
    Friend WithEvents BersihBtn As Button
    Friend WithEvents HapusBtn As Button
    Friend WithEvents dgvmahasiswa As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ttempat As TextBox
    Friend WithEvents dtlahir As DateTimePicker
    Friend WithEvents cjenjangstudi As ComboBox
    Friend WithEvents ctahunajaran As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtNama As RadioButton
    Friend WithEvents rbtNim As RadioButton
    Friend WithEvents tkata As TextBox
    Friend WithEvents CariBtn As Button
    Friend WithEvents Label9 As Label
End Class
