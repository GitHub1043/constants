Public Class Form1

    Private Sub lblRadius_Click(sender As Object, e As EventArgs) Handles lblRadius.Click

    End Sub

    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        lblResult.Text = ""
    End Sub

    Private Sub btnCircumference_Click(sender As Object, e As EventArgs) Handles btnCircumference.Click
        '1) Variables
        Dim sngCirc As Single
        Dim sngRadius As Single
        Const PI As Single = 3.14159
        'Three rules for when to constant
        '1) Value will not change
        '2) You know value at the beginning
        '3) Real world meaning (name)

        '2) Set values
        sngRadius = Val(txtRadius.Text)

        '3) Calculate
        sngCirc = 2 * PI * sngRadius

        '4) Display
        lblAnswer.Text = "= " & sngCirc

        lblResult.Text = "Result"

    End Sub

    Private Sub lblCircumference_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        '1) Variables
        Dim sngRadius As Single
        Dim sngArea As Single
        Const PI As Single = 3.14159
        'Three rules for when to constant
        '1) Value will not change
        '2) You know value at the beginning
        '3) Real world meaning (name)

        '2) Set values
        sngRadius = Val(txtRadius.Text)

        '3) Calculate
        sngArea = PI * sngRadius ^ 2

        '4) Display
        lblAnswer.Text = "= " & sngArea
        lblResult.Text = "Result"

    End Sub

    Private Sub lblArea_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolume_Click(sender As Object, e As EventArgs) Handles btnVolume.Click
        '1) Variables
        Dim sngRadius As Single
        Dim sngVolume As Single
        Const PI As Single = 3.14159
        'Three rules for when to constant
        '1) Value will not change
        '2) You know value at the beginning
        '3) Real world meaning (name)

        '2) Set values
        sngRadius = Val(txtRadius.Text)

        '3) Calculate
        sngVolume = 4 / 3 * PI * sngRadius ^ 3

        '4) Display
        lblAnswer.Text = "= " & sngVolume

        lblResult.Text = "Result"
    End Sub
End Class
