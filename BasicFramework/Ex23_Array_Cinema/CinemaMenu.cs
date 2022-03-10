using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Array_Cinema
{
	class CinemaMenu {
		public void inputRecord()
		{
			Console.WriteLine("성적데이터 입력 :");
		}
		public void deleteRecord()
		{
			Console.WriteLine("성적데이터 삭제 :");
		}
		public void sortRecord()
		{
			Console.WriteLine("성적데이터 정렬 :");
		}


		public int displayMenu()
		{
			Console.WriteLine("***************");
			Console.WriteLine("****성적 관리****");
			Console.WriteLine("1. 학생성적 입력하기");
			Console.WriteLine();
			Console.WriteLine("2. 학생성적 삭제하기");
			Console.WriteLine();
			Console.WriteLine("3. 학생성적 이름순 정렬하기");
			Console.WriteLine();
			Console.WriteLine("4. 프로그램 종료");
			Console.WriteLine();


			int menu = 0;
			do
			{
				try
				{
					menu = int.Parse(Console.ReadLine());
					if (menu >= 1 && menu <= 4)
					{
						break; //while 탈출 (1<= menu <=4)
					}
					else
					{
						//1보다 작거나 4보다 큰 값값 .. 프로그램적인 오류 (x)
						//나는 오류 보겠다 (오류 사용자 강제)
						throw new Exception("메뉴 선택 번호가 잘못 되었습니다");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine("메뉴 선택 문제 발생");
					Console.WriteLine("메뉴 1~4번까지 입력");
				}
			} while (true);
			//실행 : 사용자가 1 ~ 4까지 번호중에서 하나를 선택
			return menu;
		}


		public void startProgram() {
			while (true)
			{
				switch (displayMenu())
				{
					case 1:
						inputRecord();
						break;
					case 2:
						deleteRecord();
						break;
					case 3:
						sortRecord();
						break;
					case 4:
                        Console.WriteLine("프로그램 종료");
						Environment.Exit(0);
						break;
				}
			}
		}

	}
	
}
