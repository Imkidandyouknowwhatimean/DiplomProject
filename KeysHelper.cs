namespace UchetStudentovDlyaObrazovatelnoyOrganizacii
{
    public class KeysHelper
    {
        //Метод фиксирования длины и разрешение на ввод цифр
        public void FixedLengthAndOnlyDigits(object sender, KeyPressEventArgs e, int length)
        {
            TextBox tb = sender as TextBox;
            // Проверка на управление (Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '.' || tb.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }

            if (!char.IsDigit(e.KeyChar) || tb.Text.Length >= length)
            {
                e.Handled = true;
            }
        }
        //Запрет на введение символов в строку, кроме цифр
        public void SetOnlyDigitsKeys(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar != '.' || tb.Text.IndexOf(".") != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
