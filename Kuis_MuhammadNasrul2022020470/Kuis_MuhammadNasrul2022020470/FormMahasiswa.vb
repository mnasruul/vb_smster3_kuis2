Public Class FormMahasiswa
    Dim sql As String
    Dim proses As New koneksi
    Dim mahasiswa As DataTable
    Sub data_record()
        sql = "SELECT students.* FROM students WHERE  students.id like '%" + tkata.Text + "%' OR students.name like '%" + tkata.Text + "%'  order by id asc"
        If rbtNim.Checked Then
            sql = "SELECT students.* FROM students WHERE students.id like '%" + tkata.Text + "%' order by id asc"
        ElseIf rbtNama.Checked Then
            sql = "SELECT students.* FROM students WHERE students.name like '%" + tkata.Text + "%' order by id asc"
        End If
        mahasiswa = proses.executequery(sql)
        'dgvmahasiswa.DataSource = barang
        dgvmahasiswa.Rows.Clear()
        For i As Integer = 0 To mahasiswa.Rows.Count - 1
            dgvmahasiswa.Rows.Add(
                mahasiswa.Rows(i).Item("id"),
                mahasiswa.Rows(i).Item("name"),
                mahasiswa.Rows(i).Item("place_of_birth"),
                mahasiswa.Rows(i).Item("date_of_birth"),
             mahasiswa.Rows(i).Item("department"),
               mahasiswa.Rows(i).Item("degree"),
                mahasiswa.Rows(i).Item("academic_year"),
                mahasiswa.Rows(i).Item("telephone_number"))
        Next
    End Sub
    Sub GridDGV()
        dgvmahasiswa.Columns.Add("id", "NIM")
        dgvmahasiswa.Columns.Add("name", "Nama")
        dgvmahasiswa.Columns.Add("tempat", "Tempat")
        dgvmahasiswa.Columns.Add("tgllahir", "Tanggal Lahir")
        dgvmahasiswa.Columns.Add("jurusan", "Jurusan")
        dgvmahasiswa.Columns.Add("jenjangstudi", "Jenjang Studi")
        dgvmahasiswa.Columns.Add("tahunajaran", "Tahun Ajaran")
        dgvmahasiswa.Columns.Add("notel", "Nomor Telpon")
    End Sub
    Sub AturKolomjual()
        With dgvmahasiswa
            .Columns(0).Width = 75
            .Columns(1).Width = 100
            .Columns(2).Width = 75
            .Columns(3).Width = 75
            .Columns(4).Width = 75
            .Columns(5).Width = 75
            .Columns(6).Width = 75
            .Columns(7).Width = 75
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True

        End With
    End Sub
    Sub bersih()
        tnim.Text = ""
        tnama.Text = ""
        ttempat.Text = ""
        dtlahir.Value = Date.Now
        cjurusan.Text = ""
        cjenjangstudi.Text = ""
        ctahunajaran.Text = ""
        tnotel.Text = ""

        tnim.Focus()

        Call data_record()
    End Sub
    Sub AturSimpan()
        HapusBtn.Enabled = False
        UbahBtn.Enabled = False
        SimpanBtn.Enabled = True
        tnim.Enabled = True
    End Sub
    Sub AturHapusEdit()
        SimpanBtn.Enabled = False
        HapusBtn.Enabled = True
        UbahBtn.Enabled = True
        tnim.Enabled = False
    End Sub

    Private Sub SimpanBtn_Click(sender As Object, e As EventArgs) Handles SimpanBtn.Click
        If tnim.Text = "" Or tnama.Text = "" Or ttempat.Text = "" Or cjurusan.Text = "" Or cjenjangstudi.Text = "" Or ctahunajaran.Text = "" Or tnotel.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            mahasiswa = proses.executequery("select * from students where id='" & tnim.Text & "'")
        If mahasiswa.Rows.Count = 0 Then
                sql = "insert into students values ('" & tnim.Text & "','" & tnama.Text & "','" & ttempat.Text & "','" & dtlahir.Text & "','" & cjurusan.Text & "','" & cjenjangstudi.Text & "','" & ctahunajaran.Text & "','" & tnotel.Text & "')"
                proses.executenonquery(sql)
                MessageBox.Show("data telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("data sudah ada")
                Exit Sub
            End If
        End If
        Call bersih()
    End Sub


    Private Sub UbahBtn_Click(sender As Object, e As EventArgs) Handles UbahBtn.Click
        If MsgBox("Apakah Anda Yakin Ingin Mengedit Data Mahasiswa??", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "update students set name='" & tnama.Text & "' ,place_of_birth='" & ttempat.Text & "' ,date_of_birth='" & dtlahir.Value & "' ,department='" & cjurusan.Text & "' ,degree='" & cjenjangstudi.Text & "' ,academic_year='" & ctahunajaran.Text & "',telephone_number='" & tnotel.Text & "' where  id='" & tnim.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("Data telah Diedit..!!", "Pengeditan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan Pilih Data lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call bersih()
        Call AturSimpan()
    End Sub

    Private Sub HapusBtn_Click(sender As Object, e As EventArgs) Handles HapusBtn.Click
        If MsgBox("Apakah Anda Yakin Ingin Mengedit Data Mahasiswa??", MsgBoxStyle.YesNo, "konfirmasi") = MsgBoxResult.Yes Then
            sql = "delete from students where  id='" & tnim.Text & "'"
            proses.executenonquery(sql)
            MessageBox.Show("Data telah dihapus..!!", "Pengeditan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Silahkan Pilih Data lain..!!", "pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call bersih()
        Call AturSimpan()
    End Sub

    Private Sub BersihBtn_Click(sender As Object, e As EventArgs) Handles BersihBtn.Click
        Call bersih()
        Call AturSimpan()
    End Sub

    Private Sub TutupBtn_Click(sender As Object, e As EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

    Private Sub tnim_TextChanged(sender As Object, e As EventArgs) Handles tnim.TextChanged

    End Sub

    Private Sub tnim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnim.KeyPress
        If e.KeyChar = Chr(13) Then
            mahasiswa = proses.executequery("select * from students where id='" & tnim.Text & "'")
            If mahasiswa.Rows.Count = 0 Then
                MessageBox.Show("Data Tidak Ada Dalam Database, Silahkan Inputkan Data..!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                With mahasiswa.Rows(0)
                    tnama.Text = .Item("name")
                    ttempat.Text = .Item("place_of_birth")
                    dtlahir.Value = .Item("date_of_birth")
                    cjurusan.Text = .Item("department")
                    cjenjangstudi.Text = .Item("degree")
                    ctahunajaran.Text = .Item("academic_year")
                    tnotel.Text = .Item("telephone_number")
                End With
                Call AturHapusEdit()
            End If
        End If
    End Sub


    Private Sub dgvmahasiswa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmahasiswa.CellDoubleClick
        Try
            Dim tryData As String = dgvmahasiswa.SelectedCells(1).Value
            tnim.Text = dgvmahasiswa.SelectedCells(0).Value
            tnama.Text = dgvmahasiswa.SelectedCells(1).Value
            ttempat.Text = dgvmahasiswa.SelectedCells(2).Value
            dtlahir.Value = dgvmahasiswa.SelectedCells(3).Value
            cjurusan.Text = dgvmahasiswa.SelectedCells(4).Value
            cjenjangstudi.Text = dgvmahasiswa.SelectedCells(5).Value
            ctahunajaran.Text = dgvmahasiswa.SelectedCells(6).Value
            tnotel.Text = dgvmahasiswa.SelectedCells(7).Value
            Call AturHapusEdit()
        Catch ex As Exception
            MsgBox("Double Click Row")
        End Try
    End Sub

    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GridDGV()
        Call AturKolomjual()
        Call data_record()
        Call AturSimpan()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNama.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CariBtn.Click
        Call data_record()
    End Sub
End Class