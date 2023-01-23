<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.ctahunajaran = New System.Windows.Forms.ComboBox()
        Me.cjenislap = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cjurusan = New System.Windows.Forms.ComboBox()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cjenislap)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 59)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'ctahunajaran
        '
        Me.ctahunajaran.FormattingEnabled = True
        Me.ctahunajaran.Items.AddRange(New Object() {"2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026"})
        Me.ctahunajaran.Location = New System.Drawing.Point(164, 3)
        Me.ctahunajaran.Name = "ctahunajaran"
        Me.ctahunajaran.Size = New System.Drawing.Size(245, 21)
        Me.ctahunajaran.TabIndex = 12
        '
        'cjenislap
        '
        Me.cjenislap.FormattingEnabled = True
        Me.cjenislap.Items.AddRange(New Object() {"Data Mahasiswa Per Tahun Ajaran", "Data Mahasiwa Per Jurunsan dan Tahun Ajaran"})
        Me.cjenislap.Location = New System.Drawing.Point(164, 19)
        Me.cjenislap.Name = "cjenislap"
        Me.cjenislap.Size = New System.Drawing.Size(245, 21)
        Me.cjenislap.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(292, -13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "/"
        '
        'cjurusan
        '
        Me.cjurusan.FormattingEnabled = True
        Me.cjurusan.Items.AddRange(New Object() {"Sistem Informasi", "Sistem Komputer", "Teknik Komputer", "Manajemen Informatika"})
        Me.cjurusan.Location = New System.Drawing.Point(164, 40)
        Me.cjurusan.Name = "cjurusan"
        Me.cjurusan.Size = New System.Drawing.Size(245, 21)
        Me.cjurusan.TabIndex = 4
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(6, 43)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(44, 13)
        Me.lblJurusan.TabIndex = 3
        Me.lblJurusan.Text = "Jurusan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Laporan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tahun Ajaran"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CETAK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cjurusan)
        Me.Panel1.Controls.Add(Me.ctahunajaran)
        Me.Panel1.Controls.Add(Me.lblJurusan)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 64)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(12, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 60)
        Me.Panel2.TabIndex = 29
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 261)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ctahunajaran As ComboBox
    Friend WithEvents cjenislap As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cjurusan As ComboBox
    Friend WithEvents lblJurusan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
