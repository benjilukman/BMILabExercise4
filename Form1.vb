Public Class Form1
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim h As Single, w As Single
        h = Val(txtBox1.Text)
        w = Val(txtBox2.Text)
        resultBox.Text = BMI(h, w)
    End Sub
End Class