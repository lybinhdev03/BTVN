using BtapVN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BtapVN.Controllers
{
    public class GiaiBTController : Controller
    {
        // GET: GiaiBT
        public ActionResult Index()
        {
            return View();
        }


        //bài 1
        public ActionResult dropDown() {
            return View();
        }
        [HttpPost]
        public ActionResult dropDown(string address)
        {
            string smg = "địa chỉ: " + address + ".";
            ViewBag.smg = smg;
            return View();
        }

        //bài 2
        public ActionResult TimSoHH()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimSoHH(int n)
        {
            List<int> perfectNumbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (IsPerfectNumber(i))
                {
                    perfectNumbers.Add(i);
                }
            }

            ViewBag.PerfectNumbers = perfectNumbers;
            ViewBag.N = n;
            return View();
        }

        private bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        // bài 3
        public ActionResult TimSoCP()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TimSoCP(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                ViewBag.SquareNumbers = new List<int>();
                return View();
            }

            var numberArray = numbers.Split(',')
                                     .Select(n => int.Parse(n.Trim()))
                                     .ToList();

            List<int> squareNumbers = numberArray.Where(IsPerfectSquare).ToList();

            ViewBag.SquareNumbers = squareNumbers;
            return View();
        }

        private bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }

        // bài 4
        public ActionResult GiaiPhuongTrinhBacHai()
        {
            return View(new PhuongTrinhBacHai());
        }

        [HttpPost]
        public ActionResult GiaiPhuongTrinhBacHai(PhuongTrinhBacHai ptb2)
        {
            double a = ptb2.A;
            double b = ptb2.B;
            double c = ptb2.C;

            string result;

            if (a == 0)
            {
                if (b == 0)
                {
                    result = c == 0 ? "Phương trình có vô số nghiệm." : "Phương trình vô nghiệm.";
                }
                else
                {
                    double x = -c / b;
                    result = $"Phương trình có nghiệm x = {x}.";
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    result = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    result = $"Phương trình có nghiệm kép x = {x}.";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    result = $"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}.";
                }
            }

            ViewBag.Result = result;
            return View(ptb2);
        }

        // bài 5
        public ActionResult ThemSinhVien()
        {
            var sv = new List<SinhVien> {
                new SinhVien{
                    MaSinhVien = "1",
                    HoTen = "Ly Hong Binh",
                    NgaySinh = new DateTime(2003, 10, 20),
                    GioiTinh = "Nam",
                    QueQuan = "Ha Noi",
                    LopHoc = "15a23"
                },
                new SinhVien
                {
                    MaSinhVien = "2",
                    HoTen = "Ly Thanh Thanh",
                    NgaySinh = new DateTime(2003, 10, 20),
                    GioiTinh = "Nu",
                    QueQuan = "Ha Noi",
                    LopHoc = "15a23"
                },
                new SinhVien
                {
                    MaSinhVien = "3",
                    HoTen = "Ly Bao Anh",
                    NgaySinh = new DateTime(2003, 10, 20),
                    GioiTinh = "Nu",
                    QueQuan = "Ha Noi",
                    LopHoc = "15a23"
                }
            };

            return View(sv);
        }

    }
}