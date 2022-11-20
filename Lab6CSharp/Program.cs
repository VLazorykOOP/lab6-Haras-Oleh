using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ЗВІТ ПРИКРІПЛЕНИЙ В MOODLE!
//ЛАБОРАТОРНА РОБОТА В КЛАСРУМІ НА ГІТХАБІ https://github.com/VLazorykOOP/lab6-Haras-Oleh
//І ЛАБОРАТОРНА ПРОСТО НА МОЄМУ ВЛАСНОМУ РЕПОЗИТОРІЇ //https://github.com/Haras-Oleh

/// <summary>
/// ------------------------------------------------------------------------///
/// </summary>

//перше завдання
namespace laboratorna_robota6
{
    public interface Detal
    {
        string vurobnik { get; set; }
    }

    public interface IS_pokaz
    {
        void Show();
    }

    public class Mehanizm : Detal, IS_pokaz
    {
        public string vurobnik { get; set; }
        protected string skladnist { get; set; }
        protected string kraina { get; set; }
        int pidrahunok { get; set; }
        ~Mehanizm()
        {
            Console.WriteLine("ДЕСТРУКЦIЯ!!!");
            pidrahunok--;
        }
        public Mehanizm(string vurobnik, string skladnist, string kraina)
        {
            this.vurobnik = vurobnik;
            this.skladnist = skladnist;
            this.kraina = kraina;
            pidrahunok++;
        }

        public Mehanizm(string vurobnik)
        {
            this.vurobnik = vurobnik;
            this.skladnist = "пустота...";
            this.kraina = "пустота...";
            pidrahunok++;
        }

        public Mehanizm(string skladnist, string kraina)
        {
            this.vurobnik = "пустота...";
            this.skladnist = skladnist;
            this.kraina = kraina;
            pidrahunok++;
        }

        public void Show()
        {
            Console.WriteLine("Показати iнформацiю");
            Console.WriteLine($"vurobnik: {this.vurobnik}");
            Console.WriteLine($"skladnist: {this.skladnist}");
            Console.WriteLine($"kraina: {this.kraina}");
        }
    }

    public class Vurib : Mehanizm, Detal, IS_pokaz
    {
        protected int riven { get; set; }
        ~Vurib()
        {
            Console.WriteLine("ДЕСТРУКЦIЯ!!!");
        }
        public Vurib(string vurobnik, string skladnist, string kraina, int riven) : base(vurobnik, skladnist, kraina)
        {
            this.riven = riven;
            this.vurobnik = vurobnik;
            this.skladnist = skladnist;
            this.kraina = kraina;
        }

        public Vurib(string vurobnik) : base(vurobnik)
        {
            this.vurobnik = vurobnik;
            this.riven = -1;
            this.skladnist = "пустота...";
            this.kraina = "пустота...";
        }

        public Vurib(string skladnist, string kraina) : base(skladnist, kraina)
        {
            this.vurobnik = "пустота...";
            this.skladnist = skladnist;
            this.kraina = kraina;
            this.riven = -1;
        }

        public void Show()
        {
            Console.WriteLine("Показати iнформацiю");
            Console.WriteLine($"vurobnik: {this.vurobnik}");
            Console.WriteLine($"skladnist: {this.skladnist}");
            Console.WriteLine($"kraina: {this.kraina}");
            Console.WriteLine($"riven: {this.riven}");
        }
    }

    public class Vuzol : Mehanizm, Detal
    {
        protected string stupin { get; set; }

        ~Vuzol()
        {
            Console.WriteLine("ДЕСТРУКЦIЯ!!!");
        }
        public Vuzol(string vurobnik, string skladnist, string kraina, string stupin) : base(vurobnik, skladnist, kraina)
        {
            this.stupin = stupin;
            this.vurobnik = vurobnik;
            this.skladnist = skladnist;
            this.kraina = kraina;
        }
        public Vuzol(string vurobnik) : base(vurobnik)
        {
            this.vurobnik = vurobnik;
            this.stupin = "пустота...";
            this.skladnist = "пустота...";
            this.kraina = "пустота...";
        }

        public Vuzol(string skladnist, string kraina) : base(skladnist, kraina)
        {
            this.vurobnik = "пустота...";
            this.skladnist = skladnist;
            this.kraina = kraina;
            this.stupin = "пустота...";
        }
        public void Show()
        {
            Console.WriteLine("Показати iнформацiю");
            Console.WriteLine($"vurobnik: {this.vurobnik}");
            Console.WriteLine($"skladnist: {this.skladnist}");
            Console.WriteLine($"kraina: {this.kraina}");
            Console.WriteLine($"stupin: {this.stupin}");
        }
    }
}


//ДРУГЕ завдання
namespace laboratorna_robota6
{abstract class Trans
{
public string marka_transportu;
public string nomer_transportu;
public Trans(string marka, string nomer)
{
marka_transportu = marka;
nomer_transportu = nomer;
}
public abstract void GetInformazia_pro_Transport();
}
class Lehkove_avto : Trans
 {
public int znachennia_shvidkosti;
public int vantazhopidjomnist;
public Lehkove_avto(string marka, string nomer, int shvidkist, int Vantazhopidjomnist) : base(marka, nomer)
{
znachennia_shvidkosti = shvidkist;
vantazhopidjomnist = Vantazhopidjomnist;
 }
public override void GetInformazia_pro_Transport()
{
Console.WriteLine("Iнформацiя про легкове авто : {0},{1},{2},{3}", marka_transportu, nomer_transportu, znachennia_shvidkosti, vantazhopidjomnist);
}
}
class Motozikl : Trans
{
public int vantazhopidjomnist_motozikla;
public string naiavnist_koliaski;
public Motozikl(string marka, string nomer, string Naiavnist_koliaski, int Vantazhopidjomnist_motozikla) : base(marka, nomer)
{
vantazhopidjomnist_motozikla = Vantazhopidjomnist_motozikla;
naiavnist_koliaski = Naiavnist_koliaski;
if (naiavnist_koliaski == null) vantazhopidjomnist_motozikla = 0;
}
public override void GetInformazia_pro_Transport()
{
Console.WriteLine("Iнформацiя про мотоцикл:{0},{1},{2},{3}", marka_transportu, nomer_transportu, naiavnist_koliaski, vantazhopidjomnist_motozikla);
}
}
class Vantazhivka : Trans
{
        public int Vantazhopidjomnist_vantazhivku;
        public string Naiavnist_prichepu;
        public Vantazhivka(string marka, string nomer, int vantazhopidjomnist_vantazhivku, string naiavnist_prichepu) : base(marka, nomer)
        {
           Vantazhopidjomnist_vantazhivku = vantazhopidjomnist_vantazhivku;
           Naiavnist_prichepu = naiavnist_prichepu;
            if (naiavnist_prichepu != null) Vantazhopidjomnist_vantazhivku = vantazhopidjomnist_vantazhivku * 2;
        }
        public override void GetInformazia_pro_Transport()
        {
            Console.WriteLine("Iнформацiя про вантажiвку:{0},{1},{2},{3}", marka_transportu, nomer_transportu, Vantazhopidjomnist_vantazhivku, Naiavnist_prichepu);
        }
    }
class Baza
{
public List<Trans> baza = new List<Trans>();
public void AddTrans(Trans edit)
{
baza.Add(edit);
}
public void FindTrans(string nomer)
{
foreach (var p in baza.FindAll(p => p.nomer_transportu == nomer))
p.GetInformazia_pro_Transport();
}
}

//ТРЕТЄ завдання
namespace laboratorna_robota6
{
public class VectorUShort
{
short[] ArrayUShort { get; set; }
 uint num { get; }
uint codeError { get; set; }
static uint num_vs { get; set; }

public short this[uint i]
{
get
{
if (i > num)
{
codeError = 10;
                    return 0;
                }
                return ArrayUShort[i];
            }
            set
            {
                if (i > num)
                {
                    codeError = 10;
                }
                else
                {
                    ArrayUShort[i] = value;
                }
            }
        }

            ///Console.WriteLine("/-------------------------------------------------------/");
            public VectorUShort()
        {
                num = 1;
            ArrayUShort = new short[num];
            ArrayUShort[0] = 0;
            num_vs++;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public VectorUShort(uint num_)
        {
                num = num_;
            ArrayUShort = new short[num];
            for (int i = 0; i < num; i++)
            {
                ArrayUShort[i] = 0;
            }
            num_vs++;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public VectorUShort(uint num_, short a)
        {
                num = num_;
            ArrayUShort = new short[num];
            for (int i = 0; i < num; i++)
            {
                ArrayUShort[i] = a;
            }
            num_vs++;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            ~VectorUShort()
        {
            Console.WriteLine("ДЕСТРУКТОВАНО!!!");
            num_vs--;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public void Input()
        {
            for (int i = 0; i < this.num; i++)
            {
                Console.WriteLine($"Введiть ,будь ласка, елемент A[{i}] = ");
                this.ArrayUShort[i] = short.Parse(Console.ReadLine());
            }
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public void Output()
        {
            for (int i = 0; i < this.num; i++)
            {
                Console.WriteLine($"Массив[{i}] = {this.ArrayUShort[i]}");
            }
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public void SetVec(short A)
        {
            for (int i = 0; i < this.num; i++)
            {
                this.ArrayUShort[i] = A;
            }
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public void SetVec(uint w, short A)
        {
            if (w < 0 || w > num) { Console.WriteLine("ПОМИЛКА!!!"); }
            else
            {
                this.ArrayUShort[w] = A;

            }
        }
        public static VectorUShort operator ++(VectorUShort A)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i]++;
            }

            return A;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public static VectorUShort operator --(VectorUShort A)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i]--;
            }

            return A;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public static VectorUShort operator +(VectorUShort A, short B)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i] += B;
            }

            return A;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public static VectorUShort operator -(VectorUShort A, short B)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i] -= B;
            }

            return A;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public static VectorUShort operator *(VectorUShort A, short B)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i] *= B;
            }

            return A;
        }
        public static VectorUShort operator /(VectorUShort A, short B)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i] /= B;
            }

            return A;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public static VectorUShort operator %(VectorUShort A, short B)
        {
            for (int i = 0; i < A.num; i++)
            {
                A.ArrayUShort[i] %= B;
            }

            return A;
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.num; i++)
            {
                if (i == num) yield break;
                yield return this.ArrayUShort[i];
            }
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public IEnumerable FromTo(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                yield return this.ArrayUShort[i];
            }
        }
            ///Console.WriteLine("/-------------------------------------------------------/");
            public void ShowNum()
        {
            Console.WriteLine($"Кiлькiсть векторiв: {num_vs}");
        }

    }
}

namespace laboratorna_robota6
{
    internal class Program
    {
        static void Main(string[] args)
        {
int vubir = 0;
do
{
Console.Write("Яке завдання iз трьох Ви бажаєте перевiрити??(вибiр здiйснюється цифрою вiд 1 до 3)");
vubir = int.Parse(Console.ReadLine());
} while (vubir != 1 && vubir != 2 && vubir != 3);
switch (vubir)
{

//PERSHE ZAVDANNIA

                    case 1:
Console.WriteLine("ПЕРШЕ ЗАВДАННЯ:");
{
                        Mehanizm Mehanizm1 = new Mehanizm("Volkswagen", "Висока", "Нiмеччина");
                        Mehanizm1.Show();
                        Console.WriteLine();
                        Mehanizm Mehanizm2 = new Mehanizm("Volkswagen");
                        Mehanizm2.Show();
                        Console.WriteLine();
                        Mehanizm Mehanizm3 = new Mehanizm("Висока", "Нiмеччина");
                        Mehanizm3.Show();
                        Console.WriteLine();

                        Vurib Vurib1 = new Vurib("Bosch", "Середня", "Швейцарiя", 1);
                        Vurib1.Show();
                        Console.WriteLine();
                        Vurib Vurib2 = new Vurib("Bosch");
                        Vurib2.Show();
                        Console.WriteLine();
                        Vurib Vurib3 = new Vurib("Низька", "Швейцарiя");
                        Vurib3.Show();
                        Console.WriteLine();

                        Vuzol admin1 = new Vuzol("La Puerta Kol-da-Riko", "Низька", "Iспанiя", "Поглиблений");
                        admin1.Show();
                        Console.WriteLine();
                        Vuzol admin2 = new Vuzol("La Puerta Kol-da-Riko");
                        admin2.Show();
                        Console.WriteLine();
                        Vuzol admin3 = new Vuzol("Висока", "Iспанiя");
                        admin3.Show();
                        Console.WriteLine();

                    }
                    break;

//DRUGE ZAVDANNIA

                case 2:
Console.WriteLine("ДРУГЕ ЗАВДАННЯ:");
{
Baza c = new Baza();

c.AddTrans(new Lehkove_avto("Volkswagen", "CE1488AA", 220, 500));
c.AddTrans(new Motozikl("Volvo", "CE1337LK", null,120));
c.AddTrans(new Vantazhivka("DUFF", "CE0228CH",1500, "Причеп наявний"));

Console.WriteLine("ВСI ТРАНСПОРТНI ЗАСОБИ ЗНАЙДЕНI В БАЗI:");
foreach (var p in c.baza)
{
p.GetInformazia_pro_Transport();
}
Console.WriteLine("/-----------------------------------------------------/");
Console.WriteLine("ВСI ТРАНСПОРТНI ЗАСОБИ ЗНАЙДЕНI ПО НОМЕРУ 'CE1488AA':");
c.FindTrans("CE1488AA");
Console.ReadLine();
                    }
                    break;

                        //TRETIE ZAVDANNIA

                case 3:
                    Console.WriteLine("ТРЕТЄ ЗАВДАННЯ:");
                    {
                        Console.WriteLine("Введiть,будь ласка,число 'N': ");
                        uint n = uint.Parse(Console.ReadLine());

                        Console.WriteLine("Введiть,будь ласка,iнiцiацiю:");
                        short a = short.Parse(Console.ReadLine());

                        VectorUShort C = new VectorUShort(n, a);
                        Console.WriteLine();

foreach (short temp in C)
Console.WriteLine(temp + "");
Console.WriteLine();

foreach (short temp in C.FromTo(1, (int)n - 1))
Console.WriteLine(temp + "");

}
                        break;
                    default:
                        Console.WriteLine("Помилка!");
                        break;
                }
            }
        }
    } }
