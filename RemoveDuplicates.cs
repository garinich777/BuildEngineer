using System.Text;

void RemoveDupls(StringBuilder str)
{
    for (int i = 1; i < str.Length; i++)
        if (str[i] == str[i - 1])
            str.Remove(i--, 1);
}

var str = new StringBuilder("AAA BBB CCCC DSASDASDASDD//zz``");
RemoveDupls(str);

Console.WriteLine(str);

//Игорь Осипов
//15.09.2022
//15 минут
