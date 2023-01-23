Public Class Laporan
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cjenislap.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filter As String = ""
        Dim sourceCR As String = Application.StartupPath
        If cjenislap.Text = "Data Mahasiswa Per Tahun Ajaran" Then
            If ctahunajaran.Text = "" Then
                MsgBox("Silahkan Pilih Tahun Ajaran")
                Exit Sub
            End If
            filter = "{students.academic_year}='" & ctahunajaran.Text & "'"
            sourceCR = "D:\KULIAH\SEMESTER 3\VB\KUIS2\Kuis_MuhammadNasrul2022020470\Kuis_MuhammadNasrul2022020470\Report\LaporanMahasiswaPerTahunAjaran.rpt"
        ElseIf cjenislap.Text = "Data Mahasiwa Per Jurunsan dan Tahun Ajaran" Then
            If ctahunajaran.Text = "" Or cjurusan.Text = "" Then
                MsgBox("Silahkan Pilih Tahun Ajaran atau Jurusan")
                Exit Sub
            ElseIf ctahunajaran.Text = "" Then
                MsgBox("Silahkan Pilih Tahun Ajaran")
                Exit Sub
            ElseIf cjurusan.Text = "" Then
                MsgBox("Silahkan Pilih Jurusan")
                Exit Sub
            End If

            filter = "{students.academic_year}='" & ctahunajaran.Text & "' AND {students.department}='" & cjurusan.Text & "'"
            sourceCR = "D:\KULIAH\SEMESTER 3\VB\KUIS2\Kuis_MuhammadNasrul2022020470\Kuis_MuhammadNasrul2022020470\Report\LaporanMahasiswaPerJurusanDanPerTahunAjaran.rpt"
        Else
            MsgBox("Silahkan Pilih Jenis Laporan")
            Exit Sub
        End If


        Form1.Text = cjenislap.Text
        Form1.CrystalReportViewer1.ReportSource = Nothing
        Form1.CrystalReportViewer1.RefreshReport()
        Form1.CrystalReportViewer1.SelectionFormula = filter
        Form1.CrystalReportViewer1.ReportSource = sourceCR
        Form1.WindowState = FormWindowState.Maximized
        Form1.Show()
    End Sub

    Private Sub cjenislap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cjenislap.SelectedIndexChanged
        If cjenislap.Text = "Data Mahasiswa Per Tahun Ajaran" Then
            cjurusan.Visible = False
            ctahunajaran.Visible = True
            lblJurusan.Visible = False
        ElseIf cjenislap.Text = "Data Mahasiwa Per Jurunsan dan Tahun Ajaran" Then
            cjurusan.Visible = True
            ctahunajaran.Visible = True
            lblJurusan.Visible = True
        End If
    End Sub
End Class