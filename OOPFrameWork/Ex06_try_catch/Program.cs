using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_try_catch
{
    //예외처리  : 개발자가 코드를 통해서 문제를 발생 ....
    //개선의 여지가 있다
    //내가 만든 코드가 문제가 있을까 , 문제 없어 확신 ...

    //try ~ catch ~ finally
    //코드를 수정하는 것이 아니고 프로그램이 강제로 죽는 것 방지 ....
    //문제를 인지하고 추후에 코드는 수정해야 한다 ...
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = null;
            Console.WriteLine(str.ToString());  //예외가 발생  >> System.NullReferenceException >> 프로그램 강제 종료
            Console.WriteLine("성공 종료^^");
            */
            /*
             처리되지 않은 예외: System.NullReferenceException: 개체 참조가 개체의 인스턴스로 설정되지 않았습니다.
             위치: Ex06_try_catch.Program.Main(String[] args) 파일 D:\Ecount\Labs\OOPFrameWork\Ex06_try_catch\Program.cs:줄 21
             */

            string str = null;
            try
            {
                Console.WriteLine(str.ToString()); //문제가 발생

                //내부적으로 ... 예외를 담을 수 있는 객체가 자동 생성되고 ... 그 객체에 문제를 담고 ... 그 주소를
                //Exception e 전달


                //1. 계층 구조 : https://docs.microsoft.com/ko-kr/dotnet/api/system.nullreferenceexception?view=net-6.0
                //public class NullReferenceException : SystemException
                //상속   Object  ->  Exception  ->  SystemException -> NullReferenceException

                //2. 부모타입의 변수는 자식타입의 주소를 받을 수 있다 (다형성)

                //3. Exception e  = new NullReferenceException("문제 발생에 코드..문자열") 

                //try 문제가 생기면 .... 자동으로 그 문제에 대한 객체를 생성 ...new NullReferenceException("문제 발생에 코드..문자열") 

                //4. 그런데   catch (Exception e) 코드를 생성 ...  catch(NullReferenceException e) 로 하지 않았을까

                //5. 결국 무슨 예외가 발생 알수 없어요 그래요 모든 예외의 부모를 가지고 다 받아서 처리 ....

                //상위 예외가 뒤에 .....


                //6. 코드 try ... 비용 ... 쓰는 것 ... 알수 없어요 ...
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);

                //1. log 파일에 정보 기록 >> 수정 
                //2. 메일 시스템 연동 문제 .. 관리자 (담당자) 메일 >> 수정
            }
            catch (Exception n) {
                Console.WriteLine(n.Message);
            }
            Console.WriteLine("성공 종료^^");

        }
    }
}
