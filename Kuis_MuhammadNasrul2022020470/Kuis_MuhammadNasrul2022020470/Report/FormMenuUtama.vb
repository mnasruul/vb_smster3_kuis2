Public Class FormMenuUtama
    Private Sub MahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaToolStripMenuItem.Click
        FormMahasiswa.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.ShowDialog()
    End Sub
End Class