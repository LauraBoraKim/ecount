/*
CREATE TABLE EMP
(EMPNO int not null,
ENAME VARCHAR(10),
JOB VARCHAR(9),
MGR int,
HIREDATE datetime,
SAL int,
COMM int,
DEPTNO int);

INSERT INTO EMP VALUES
(7369,'SMITH','CLERK',7902,'1980-12-17',800,null,20);
INSERT INTO EMP VALUES
(7499,'ALLEN','SALESMAN',7698,'1981-02-20',1600,300,30);
INSERT INTO EMP VALUES
(7521,'WARD','SALESMAN',7698,'1981-02-22',1250,200,30);
INSERT INTO EMP VALUES
(7566,'JONES','MANAGER',7839,'1981-04-02',2975,30,20);
INSERT INTO EMP VALUES
(7654,'MARTIN','SALESMAN',7698,'1981-09-28',1250,300,30);
INSERT INTO EMP VALUES
(7698,'BLAKE','MANAGER',7839,'1981-04-01',2850,null,30);
INSERT INTO EMP VALUES
(7782,'CLARK','MANAGER',7839,'1981-06-01',2450,null,10);
INSERT INTO EMP VALUES
(7788,'SCOTT','ANALYST',7566,'1982-10-09',3000,null,20);
INSERT INTO EMP VALUES
(7839,'KING','PRESIDENT',null,'1981-11-17',5000,3500,10);
INSERT INTO EMP VALUES
(7844,'TURNER','SALESMAN',7698,'1981-09-08',1500,0,30);
INSERT INTO EMP VALUES
(7876,'ADAMS','CLERK',7788,'1983-01-12',1100,null,20);
INSERT INTO EMP VALUES
(7900,'JAMES','CLERK',7698,'1981-10-03',950,null,30);
INSERT INTO EMP VALUES
(7902,'FORD','ANALYST',7566,'1981-10-3',3000,null,20);
INSERT INTO EMP VALUES
(7934,'MILLER','CLERK',7782,'1982-01-23',1300,null,10);

CREATE TABLE DEPT
(DEPTNO int,
DNAME VARCHAR(14),
LOC VARCHAR(13) );

INSERT INTO DEPT VALUES (10,'ACCOUNTING','NEW YORK');
INSERT INTO DEPT VALUES (20,'RESEARCH','DALLAS');
INSERT INTO DEPT VALUES (30,'SALES','CHICAGO');
INSERT INTO DEPT VALUES (40,'OPERATIONS','BOSTON');

CREATE TABLE BONUS
(
ENAME VARCHAR(10),
JOB VARCHAR(9),
SAL int,
COMM int
);


CREATE TABLE SALGRADE
( GRADE int,
LOSAL int,
HISAL int );

INSERT INTO SALGRADE VALUES (1,700,1200);
INSERT INTO SALGRADE VALUES (2,1201,1400);
INSERT INTO SALGRADE VALUES (3,1401,2000);
INSERT INTO SALGRADE VALUES (4,2001,3000);
INSERT INTO SALGRADE VALUES (5,3001,9999);
*/

/*
DDL(Data Definition Language): 데이터 정의 언어, 데이터베이스 개체의 생성/변경/삭제을 목적으로 사용하는 언어
Create ...

Alter ...

Drop ...


DCL(Data Control Language): 데이터 제어 언어, 데이터 제어를 정의하고 기술하는 언어, 누가 데이터를 제어할 수 있는지를 지정하는 언어.
DB관리자
Grant .. 허락

Revoke ..Grant 했다가 ... 

Deny  접근 금지 ...



DML(Data Manipulation Language): 데이터 조작 언어, 데이터 자체를 처리하고 조작하기 위한 언어
개발자 ....
select (60%) >> 함수 , 조인 , 서브쿼리 , 뷰...

insert 

update

delete

*/

select * from emp;

select * from dept;

select * from salgrade;

--1. 사원 테이블에 있는 모든 사원테이터를 출력하세요
select *
from emp;

--2. 특정 컬럼(사번 , 이름 , 급여) 만 출력하세요
select empno , ename , sal from emp;

--3. 부서테이블이 있는 부서번호 , 부서이름 출력하세요
select deptno , dname from dept;

--4. 사원번호 , 사원이름 컬럼명을 출력시 한글로 ...
select empno 사원번호 , ename 사원이름 from emp;

select empno as '사원 번호' , ename as '사원 이름' from emp;

--5. 사원테이블에서 직종을 출력하세요
--우리회사에 직종이 몇개나 있지 ...
--중복된 열 제거 출력
select job from emp;

select distinct job from emp;

--SQL (언어) 질의를 할 수 있는 언어
--연산자 
--1.산술 , 비교 , 논리

--6. 사원테이블에서 사번, 이름 , 급여 , 300달러 인상된 급여를 출력하세요
select * from emp;

select empno , ename , sal , sal + 300 as '인상급여' from emp;

--7. 사원테이블에서 사번 , 이름 , 급여 , 연봉(급여 *12)을 출력하세요
select * from emp;

select empno, ename, sal , sal * 12 as '연봉' from emp;

--8. Null (필요악)
--회원 테이블 ... 회원번호 , 회원명 , 핸드폰 , 취미  (필수 입력 , 옵션 null )
select * from emp;

select empno , sal , comm from emp;
--comm 데이터 null >> comm 을 받지 않는 구나
--7844	1500	0 받지 않는 것이지만 수업용 확인 .....

--9 사원 테이블에서 사번 , 이름 , 직종 , 급여 , 수당 , 급여+수당을 출력하세요
select empno , ename , job , sal , comm , sal + comm as '총급여' from emp;

-- POINT > Null 과의 모든 연산의 결과는  >> Null
--Null 처리하는 함수 .....
--Oracle : nvl()     >> select nvl(comm,0)
--Mysql  : ifnull()  >> select ifnull(comm,0)
--Mssql  : isnull()
select sal + isnull(comm,0) from emp;

select sal + isnull(comm,11111) from emp;


select empno , ename , job , sal , comm , sal + isnull(comm,0) as '총급여' from emp;


/*
실행순서
select   3
from     1 
where    2

*/
--사원테이블에서 사번이 7788인 사원의 사번 , 이름 ,급여를 출력하세요
select empno , ename , sal
from emp
where empno=7788;

--사원테이블에서 사원이름이 SMITH 인 사원의 모든 정보를 출력하세요
select *
from emp
where ename ='smith';

select *
from emp
where ename ='SMITH';

--Oracle 은 문자열 데이터 대소문 엄격하게 구분
--where ename ='smith';  안나와요
--where ename ='SMITH';  출력이되요 

--사원테이블에서 입사일 1980년 12월 17일인 사원의 모든 정보를 정보를 출력하세요
--날짜 데이터도 문자열 처럼 '' 사용해서 처리
select * from emp
where hiredate ='1980-12-17';



select * from emp
where hiredate ='1980/12/17';

select * from emp
where hiredate ='80/12/17';

--직종이  salesman 인 사원의 사번 , 이름 ,급여 ,직종을 출력하세요
select empno , ename,  sal , job
from emp
where job = 'SALESMAN';

--부서번호가 10인 사원의 부서번호 , 이름 , 급여 정보를 출력하세요
select deptno , ename , sal
from emp
where deptno = 10;

--비교 연산
--사원테이블에서 급여가 3000이상인 사원의 이름과 급여를 출력하세요
select ename , sal
from emp
where sal >= 3000;

--사원테이블에서 직종이 salesman 이 아닌 사원의 사번 , 이름 , 직종을 출력하세요
select *
from emp
where job != 'SALESMAN';

select *
from emp
where job <> 'SALESMAN'; --참고


--사원테이블에서 연봉이 3000 이상인 사원의 사번 , 이름 , 급여 , 연봉을 출력하세요
select empno , ename , sal , sal*12 as '연봉'
from emp
where (sal * 12) >= 3000;


use KosaDB;

--직종이 salesman 이고 급여가 2000이상인 사원의 사번 , 이름 , 급여 , 직종을 출력하세요
--and 
select * from emp
where job = 'SALESMAN' and sal >= 1500;


--직종이 salesman 이거나 급여가 2000이상인 사원의 사번 , 이름 , 급여 , 직종을 출력하세요
select * from emp
where job = 'SALESMAN' or sal >= 1500;


--사원테이블에서 급여가 1000이상 3000이하인 사원의 사번, 이름 ,급여를 출력하세요
select *
from emp
where sal >= 1000 and sal <= 3000;

--between A and B  (=을 포함)
select *
from emp
where sal between 1000 and 3000;

--사원테이블에서 급여가 1000초과 3000미만인 사원의 사번, 이름 ,급여를 출력하세요
select *
from emp
where sal > 1000 and sal < 3000;

--사원테이블에서 사번이 7788 , 7902 , 7369 인 사원의 사번과 이름을 출력하세요
select *
from emp
where empno=7788 or empno=7902 or empno=7369;

--in 연산자 
select *
from emp
where empno in (7788,7902,7369);

--사원테이블에서 사번이 7788 , 7902 , 7369 아 아닌 사원의 사번과 이름을 출력하세요

select *
from emp
where empno not in (7788,7902,7369);

--Like 연산자 (패턴 : 문자열)



--like  연산자를 도와주는 wild card
--% 모든 것  (아무것도 없는 경우)
--_ 한문자
--[] 안에 있는 문자
--[^] 다음에 있는 것은 제외

--사원테이블에서 이름이 S로 시작하는 사원의 사번과 이름을 출력하세요
select * 
from emp
where ename like 'S%';

--이름의 두번째 글자가 A인 사원의 사번과 이름을 출력하세요
select *
from emp
where ename like '_A%'; --두번째 
/*
WARD
MARTIN
JAMES

*/

--이름에 T 가 두번 들어있는 사원
-- TT ,  ATAT
select *
from emp
where ename like '%T%T%'

--SCOTT

--이름의 첫글자가 A , B , S 로 시작하는 사원정보

select *
from emp
where ename like '[ABS]%'
/*
SMITH
ALLEN
BLAKE
SCOTT
ADAMS
*/

--이름의 첫글자가 A or S 시작하고 두번째 글자가 C가 아닌 경우
select *
from emp
where ename like '[AS][^C]%'

----------------------------------------------------------------------------------
--QUESTION
--1. 사원테이블에서 모든 데이터를 출력하라
select *
from emp

--2. 사원테이블에서 사원번호, 사원이름, 월급을 출력하라
select empno, ename, sal
from emp

--3. 사원테이블에서 월급을 뽑는데 중복된 데이터가 없게 출력하라
select distinct sal
from emp

--4. 사원테이블에서 사원이름과 월급을 출력하는데 각각의 컬럼명을
-- '이 름','월 급'으로 바꿔서 출력하라. 단, ALIAS에 공백추가
select ename as '이 름', sal as '월 급'
from emp

--5. 사원테이블에서 사원이름, 월급을 뽑고, 월급과 커미션을  더한 값을
-- 출력하는데 컬럼명을 '실급여'이라고 해서 출력하라.
-- 단, NULL값은 나타나지 않게 하라.
select ename, sal, sal+isnull(comm,0) as '실급여'
from emp

--6. 사원테이블에서 'SCOTT'이라는 사원의 사원번호, 이름, 월급을 출력하라
select empno, ename
from emp
where ename='SCOTT'

--7. 사원테이블에서 직위가 'SALESMAN'인 사원의 사원번호, 이름, 직위를
-- 출력하라
select empno, ename, job
from emp
where job='SALESMAN'

--8. 사원테이블에서 사원번호가 7499, 7521, 7654인 사원의 사원번호, 이름
-- 월급을 출력하라
select empno, ename, sal
from emp
where empno in(7499,7521,7654)

--9. 사원테이블에서 월급이 1500에서 3000사이인 사원의 사원번호, 이름,
-- 월급을 출력하라.
select empno, ename, sal
from emp
where sal between 1500 and 3000

--10. 사원테이블에서 이름의 첫글자가 A이고 마지막 글자가 N이 아닌 사원의
-- 이름을 출력하라
select ename
from emp
where ename like 'A%[^N]'



create table Tlike(
   col1 int,
   col2 varchar(10) --10byte  (한글 5자 , 영문자, 특수문자 ,공백 10자)
)
--class Tlike { private int col1, private string col2}
insert into Tlike(col1, col2) values(10,'10')
insert into Tlike(col1, col2) values(20,'10%')
insert into Tlike(col1, col2) values(30,'20')

select * from tlike

select * from tlike where col2 like '%10%'

--'10%' 검색
select * from tlike where col2 like '%10E%%' ESCAPE 'E'
--ESCAPE 'E' 라는 문자 뒤에는 데이터인지  >> 10E%

--Today Point
--사원테이블에서 커미션(수당)이 책정되어 있지 않은 (받지 않는)
--사원의 이름과 커미션을 출력해라( 단 comm > 0 인것 받는것으로 인정)


--select * from emp where comm = null; 문법이 없어요
--null 조건은 
--1. is null
--2. is not null

select * from emp where  comm is null

--수당을 받는 사원들은
select * from emp where comm is not null

--함수
--문자함수 , 숫자함수 , 날짜함수 , 계산함수 ,시스템 함수 ...

--1. 문자함수
select lower('ABC')
select upper('abc')

select upper(ename) as 'ename' from emp

select 100+100+100
select ename + 'is a ' + job from emp -- + 연산 or 결합(문자열) 

select substring('abcd',1,3)
select substring('abcd',3,1)  -- 1 자기자신

select left('abcd',3)
select right('abcd',3)

--사원테이블에서 사원의 이름에서 첫글자는 대문자로 나머지는 소문자로 출력하세요
--a().b().c() 체인 (x) SQL은
--a(b(c()))

select upper(left(ename,1)) + lower(substring(ename,2,20)) as 'ename' from emp 

select upper(left(ename,1)) + lower(substring(ename,2,len(ename))) as 'ename' from emp 

select len('abcd')
select len(ename) from emp

select len('a       b')
select len('     a')
select len('a         ')-- len함수는 후행공백 인지 못한다

select datalength('abc')  -- 3byte
select datalength('홍길동') --6byte


--공백제거
select '>' +  '     a' + '<'
-->     a<

select '>' +  ltrim('     a') + '<'
-->a<
select '>' +  rtrim('a      ') + '<'


select '>' +  rtrim(ltrim('     a     ')) + '<'

--replace
select replace('abcd','a','NEWNEW')

--'홍      길     동'
select '>' + '홍      길     동' + '<'
--데이터 안쪽에 공백
--결과 '홍길동'

select replace('홍      길     동',' ','')
--홍길동

--숫자함수
select round(123.45,1) --123.50   반올림 함수
select round(123.45,2) --123.45 
select round(123.45,0) --123
select round(123.55,0) --124.00

select power(2,4)

--CEILING: 지정된 숫자보다 큰 최소 정수를 반환하여 출력
SELECT CEILING(1234.5678), CEILING(123.45), CEILING(-1234.56)


--FLOOR: 지정된 숫자보다 작은 최대 정수를 반환하여 출력
SELECT FLOOR(1234.5678), FLOOR(123.45), FLOOR(-1234.56)
--1234	123	-1235

--날짜 함수 
select getdate() -- 2022-03-22 14:46:16.767

--Oracle : select sysdate
select dateadd(yy,10,getdate())
select dateadd(mm,5,getdate())
select dateadd(dd,100,getdate())

select dateadd(yy,10,'2022-01-01')

select datediff(yy,'2010-12-12','2022-01-13')
select datediff(mm,'2010-12-12','2022-01-13')
select datediff(dd,'2010-12-12','2022-01-13')

--단 조건이 월은 30일까지 
select ename, 
         datediff(dd,hiredate,getdate()) / 365  as '년',
         (datediff(dd,hiredate,getdate()) % 365)/30 as '개월',
          (datediff(dd,hiredate,getdate()) % 365) % 30 as '일'
from emp


--오늘부터 연말 12-31일까지 몇일 남았나요
select datediff(dd, getdate(),'2022-12-31')

select year(getdate())
select month(getdate())
select day(getdate())

--문자 , 숫자 , 날짜 함수 기본적인 사용

--형변환 함수 (Today Point)
select convert(int,'100') + 100
select convert(int,'100A') + 100  --varchar 값 '100A'을(를) 데이터 형식 int(으)로 변환하지 못했습니다.

--오라클 select * from dual;

select convert(varchar(20),sal) + '급여입니다 '
from emp

select ename  + ' 의 사번은' + convert(varchar(20),empno) + ' 입니다' as 'fullname'
from emp

--집계함수 
--sum() , avg() , max() , min() , count()

select sum(sal) from emp
select avg(sal) from emp
select max(sal) from emp
select min(sal) from emp
select count(empno) from emp

/*
1. 집계함수는 null 값을 무시한다 (단 count(*) 제외)
2. select 절에 집계함수 이외에 다른 컬럼이 오면 반드시 그 컬럼은 group by절에 명시되어야 한다
*/

select comm from emp  --14
select count(comm) from emp --null 무시
select comm from emp where comm is not null

--comm 평균
select avg(comm) from emp  --721  우리회사는 받는 사원수를 기준 ... 집계함수는 null무시
--우리회사는 사원수를 기준 ...
--우리회사는 받는 사원수를 기준 
select (300 + 200 + 30 + 300 + 3500 + 0) /6  --721
select (300 + 200 + 30 + 300 + 3500 + 0) /14 --309

--우리회사는 사원수를 기준 ...
select avg(isnull(comm,0))  from emp  --309  ---Today POINT

--집계함수를 결과는 1건
select avg(sal) , sum(sal) , max(sal) , min(sal), count(sal) from emp


select deptno , sum(sal) 
from emp
group by deptno


select deptno , sum(sal)  , max(sal) , min(sal), count(sal)
from emp
group by deptno


select deptno , job , avg(sal)
from emp
group by deptno , job
order by deptno asc

/*
select          4   
from            1 
where           2
group by        3
order by        5  성능  (select 한 정렬)

*/

--직종별 평균월급을 구하되 컬럼 가명칭은 '평균'  평균월급이 높은 순으로 데이터를 정렬하세요
select job , avg(sal) as '평균'
from emp
group by job
order by 평균 desc 

--mssql Top n 쿼리
--사원테이블에서 월급을 가장 많이 받는 사원 5명의 이름과 급여를 출력하세요

select top 5 ename , sal
from emp
order by sal desc


select top 2  with ties ename , sal  --동률 처리하기 
from emp
order by sal desc

select top 50 percent ename, sal
from emp
order by sal desc

--직업별 총월급을 구하고 총월급이 5000이상인 모든 사원데이터를 출력하세요

--from 절의 조건절  where
--group by 절의 조건절 having 

--단일테이블 (모든 구문)
/*
select             5
from               1
where              2
group by           3
having             4
order by           6 
*/

select job , sum(sal) as 'sumsal'
from emp
where deptno != 10
group by job
having sum(sal) >= 5000
order by sumsal desc

--부서별 월급의 합을 구하고 그 총합이 10000이상인 사원 데이터를 출력하세요

select deptno , sum(sal) as 'sumsal'
from emp
group by deptno
having sum(sal) >= 10000

--부서별 총월급을 구하되 30번부서를 제외하고, 
--그 총월급이 8000달러 이상인 부서만 나오게하고, 
--총월급이 높은 순으로 출력하라.
select deptno , sum(sal) as 'sumsal'
from emp
where deptno != 30
group by deptno
having sum(sal) >= 8000
order by sumsal desc


--부서별 평균월급을 구하되 커미션이 책정된 사원만 가져오고, 
--그 평균월급이 2000달러 이상인 부서만 나오게하고, 
--평균월급이 높은 순으로 출력하라
select deptno , avg(sal) as 'avgsal'
from emp
where comm is not null
group by deptno
having avg(sal) >=2000
order by avgsal desc


--QUESTION
--1. 사원 테이블에서 사원이름을 첫글자는 대문자로, 나머지는 소문자로 출력하라
SELECT UPPER(LEFT(ENAME,1))+LOWER(SUBSTRING(ENAME,2,8))
FROM EMP

--2. 사원테이블에서 사원이름을 뽑고 또 이름의 두번째 글자부터 네번째 글자까지
-- 출력하라.
SELECT ENAME, SUBSTRING(ENAME,2,3)
FROM EMP

--3. 사원테이블의 사원 이름의 철자 개수를 출력하라.
SELECT LEN(ENAME)
FROM EMP

--4. 사원테이블에서 사원 이름의 앞 글자 하나와 마지막 글자 하나만 출력하되 
-- 모두 소문자로 각각 출력하라.
SELECT LOWER(LEFT(ENAME,1)), LOWER(RIGHT(ENAME,1))
FROM EMP

--5. 3456.78의 소수점 첫번째 자리에서 반올림하라.
SELECT ROUND(3456.78, 0)

--6. 3의 4제곱을 구하고, 64의 제곱근을 구하라.
SELECT POWER(3,4), SQRT(64)
-->: 제곱근은 소수점 이하로 나타날 수 있기 때문에 float형으로 출력된다.

--7. 오늘날짜와 오늘날짜에서 10일을 더한 날짜를 출력하라.
SELECT GETDATE(), DATEADD(DD,10,GETDATE())
--OR
SELECT GETDATE(),GETDATE()+10

--8. 국제 표준으로 현재 날짜를 출력하라.
SELECT CONVERT(VARCHAR(20), GETDATE(), 112)

--9. 사원테이블에서 사원이름과 사원들의 오늘 날짜까지의 근무일수를 구하라.
SELECT ENAME, DATEDIFF(DD, HIREDATE, GETDATE())
FROM EMP

--10. 위 문제에서 근무일수를 00년 00개월 00일 근무하였는지
--확인할 수 있도록 변환하라.(단, 한 달을 30일로 계산하라)
-- 예)
--  | ENAME	| 근무일수		|
--  | KING	| 00년 00개월 00일	|

SELECT ENAME,
CONVERT(VARCHAR(20),DATEDIFF(DD, HIREDATE, GETDATE())/365)+'년 '+
CONVERT(VARCHAR(20),DATEDIFF(DD, HIREDATE, GETDATE())%365/30)+'개월 '+
CONVERT(VARCHAR(20),DATEDIFF(DD, HIREDATE, GETDATE())%365%30)+'일'
FROM EMP



--1. 사원테이블에서 부서별 최대 월급을 출력하라.
SELECT DEPTNO, MAX(SAL)
FROM EMP
GROUP BY DEPTNO

--2. 사원테이블에서 직위별 최소 월급을 구하되 직위가 
-- CLERK인 것만 출력하라.
SELECT JOB, MIN(SAL)
FROM EMP
WHERE JOB='CLERK'
GROUP BY JOB

--3. 커미션이 책정된 사원은 모두 몇 명인가?
SELECT COUNT(COMM)
FROM EMP

--4. 직위가 'SALESMAN'이고 월급이 1000이상인 사원의
-- 이름과 월급을 출력하라.
SELECT ENAME, SAL
FROM EMP
WHERE JOB='SALESMAN' AND SAL>=1000

--5. 부서별 평균월급을 출력하되, 평균월급이 2000보다
-- 큰 부서의 부서번호와 평균월급을 출력하라.
SELECT DEPTNO, AVG(SAL)
FROM EMP
GROUP BY DEPTNO
HAVING AVG(SAL)>=2000

--6. 사원테이블에서 커미션을 가장 많이 받는 사원 2명을
-- 출력하되 랭킹이 중복될 경우 동률처리를 하여 출력하라.
SELECT TOP 2 WITH TIES ENAME, COMM
FROM EMP
ORDER BY COMM DESC

--7. 직위가 MANAGER인 사원을 뽑는데 월급이 높은 사람
-- 순으로 이름, 직위, 월급을 출력하라.
SELECT ENAME, JOB, SAL
FROM EMP
WHERE JOB='MANAGER'
ORDER BY SAL DESC

--8. 각 직위별로 총월급을 출력하되 월급이 낮은 순으로
-- 출력하라.
SELECT JOB, SUM(SAL) 
FROM EMP
GROUP BY JOB
ORDER BY SUM(SAL) --OR ORDER BY SUM(SAL) ASC

--9. 직위별 총월급을 출력하되, 직위가 'MANAGER'인
-- 사원들은 제외하라. 그리고 그 총월급이 5000보다 
-- 큰 직위와 총월급만 출력하라.
SELECT JOB, SUM(SAL)
FROM EMP
WHERE JOB != 'MANAGER'
GROUP BY JOB
HAVING SUM(SAL)>5000

--10. 직위별 최대월급을 출력하되, 직위가 'CLERK'인 
-- 사원들은 제외하라. 그리고 그 최대월급이 2000 이상인
-- 직위와 최대월급을 최대 월급이 높은 순으로 정렬하여 
-- 출력하라.
SELECT JOB, MAX(SAL) as 'maxsal'
FROM EMP
WHERE JOB!='CLERK'
GROUP BY JOB
HAVING MAX(SAL)>=2000
ORDER BY maxsal DESC


use KosaDB
--JOIN
--조인 실습 테이블 만들기
CREATE TABLE M
(M1 CHAR(6), M2 VARCHAR(10))

CREATE TABLE S
(S1 CHAR(6), S2 VARCHAR(10))

CREATE TABLE X
(X1 CHAR(6), X2 VARCHAR(10))

 

INSERT INTO M VALUES('A','1')
INSERT INTO M VALUES('B','1')
INSERT INTO M VALUES('C','3')
INSERT INTO M VALUES(NULL, '3')

 

INSERT INTO S VALUES('A','X')
INSERT INTO S VALUES('B','Y')
INSERT INTO S VALUES(NULL, 'Z')

 

INSERT INTO X VALUES('A','DATA')

select * from m
select * from s
select * from x

/*
조인 한개 이상의 테이블에서 데이터를 가져오는 방법

종류
inner join
cross join
outer join
self  join
nonequi join

표현법
각 벤더 (oracle, mysql , mssql) 문법이 존재
표준문법 : ansi 문법 ^^
*/

-- inner join

--SQL 문법
select * from m , s where m1 = s1

select m1 , m2 , s2
from m , s
where m1 = s1

--ANSI
select *
from m inner join s 
on m1 = s1

select m.m1 , m.M2 , s.S1 , s.s2
from m inner join s
on m.m1 = s.s1

--사원테이블에서 사번 , 이름 , 부서번호 , 부서이름을 출력하세요
select * from emp
select * from dept

select emp.empno , emp.ename , emp.deptno , dept.dname
from emp inner join dept
on emp.deptno = dept.deptno

--완성된 구문
select e.empno, e.ename , e.deptno , d.dname
from emp e inner join dept d
on e.deptno = d.deptno

select e.empno, e.ename , e.deptno , d.dname
from emp e join dept d  --default inner 
on e.deptno = d.deptno

-------------------------------------------------------------
--cross join (조건이 없는 조인)
select * from m , s

--ansi
select *
from m cross join s

---------------------------------------------------------------
--outer join
--조인에 만족하지 않는 데이터가 생성
--남는 데이터를 가져오는 방법 (null)

--내부적으로 [inner join 선행]하고 주종관계를 파악해서 남는 데이터를 가지고 오는 방법
--left , right
select *
from m left outer join s
on m.m1 = s.s1

select *
from m right outer join s
on m.m1 = s.s1


select *
from m full outer join s
on m.m1 = s.s1
--원리 : reft  와 right  >> union 

----------------------------------------------------
--union 합집합
--1. 대응대는 [컬럼의 수]가 [일치]하여야 한다
--2. 대응대는 [컬럼의 자료형(타입)] 일치

select empno , ename from emp
union 
select deptno , dname from dept


select empno , ename , job from emp
union 
select deptno , dname ,null from dept


select ename  , empno from emp  --ename varchar
union 
select deptno , dname from dept  --deptno int


select * from emp
union  --중복제거
select * from emp

select * from emp
union all
select * from emp

-----------------------------------------------------
--self join (한개의 테이블 2개 처럼)
--자신의 특정 컬럼의 자신의 특정 컬럼을 참조

--사번 , 이름 ,관리자사번 , 관리자 이름 출력하세요

select e.empno , e.ename , m.empno , m.ename
from emp e inner join emp m
on e.mgr = m.empno

--^^ 문제 발생 사원은 14명 
--현재 데이터는 13명
--null join의 대상이 아니다
select * from emp

select e.empno , e.ename , m.empno , m.ename
from emp e left outer join emp m
on e.mgr = m.empno

----------------------------------------------------
select * from emp
select * from salgrade

select e.empno , e.ename , e.sal , s.grade
from emp e inner join salgrade s
on e.sal between s.losal and s.hisal
--1:1 매핑되는 컬럼이 없어요 .... 있어요  >> inner join

----------------------------------------------------------------
--테이블 2 , 3, 4 개 조인
select m.m1 , m.m2 ,  s.s2 , x.X2
from m join s on m.m1 = s.s1
       join x on s.s1 = x.x1

/*
select m.m1 , m.m2 ,  s.s2 , x.X2
from m join s on m.m1 = s.s1
       join x on s.s1 = x.x1
	   join y on x.x1 = y.y1
*/
--사원의 사번 , 이름 , 급여 , 급여등급 , 부서번호 , 부서이름을 출력하세요
select *
from emp e join dept d on e.deptno = d.deptno
           join salgrade s on e.sal between s.losal and s.hisal

--부서번호가 10번인 사원들의 부서번호, 부서이름, 사원번호, 사원이름을 출력하라.
select *
from emp e join dept d on e.deptno = d.deptno
where e.deptno = 10 

--부서번호가 20번 이하인 사원들의 부서번호, 부서이름, 사원번호, 사원이름을 출력하되, 부서번호가 낮은 순으로 정렬하라.
select *
from emp e join dept d on e.deptno = d.deptno
where e.deptno <= 20
order by d.deptno

-- 1. 사원들의 이름, 부서번호, 부서이름을 출력하라.
SELECT E.ENAME, E.DEPTNO, D.DNAME
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO

-- 2. DALLAS에서 근무하는 사원의 이름, 직위, 부서번호, 부서이름을
-- 출력하라.
SELECT E.ENAME, E.JOB, D.DEPTNO, D.DNAME
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO 
WHERE  LOC='DALLAS'

-- 3. 이름에 'A'가 들어가는 사원들의 이름과 부서이름을 출력하라.
SELECT E.ENAME, D.DNAME
FROM EMP E inner join DEPT D
on D.DEPTNO=E.DEPTNO 
WHERE  E.ENAME LIKE '%A%'

-- 4. 사원이름과 그 사원이 속한 부서의 부서명, 그리고 월급을 
--출력하는데 월급이 3000이상인 사원을 출력하라.
SELECT e.ENAME, d.DNAME, e.SAL , e.deptno
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO 
where e.SAL>=3000

-- 5. 직위가 'SALESMAN'인 사원들의 직위와 그 사원이름, 그리고
-- 그 사원이 속한 부서 이름을 출력하라.
SELECT E.JOB, E.ENAME, D.DNAME
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO 
where E.JOB='SALESMAN'

-- 6. 커미션이 책정된 사원들의 사원번호, 이름, 연봉, 연봉+커미션,
-- 급여등급을 출력하되, 각각의 컬럼명을 '사원번호', '사원이름',
-- '연봉','실급여', '급여등급'으로 하여 출력하라.
SELECT E.EMPNO AS '사원번호', E.ENAME AS '사원이름', 
	E.SAL*12 AS '연봉', E.SAL*12+isnull(COMM,0) AS '실급여',
	S.GRADE AS '급여등급'
FROM EMP E inner join SALGRADE S on E.SAL BETWEEN S.LOSAL AND S.HISAL
where COMM IS NOT NULL

-- 7. 부서번호가 10번인 사원들의 부서번호, 부서이름, 사원이름,
-- 월급, 급여등급을 출력하라.
SELECT E.DEPTNO, D.DNAME, E.ENAME, E.SAL, S.GRADE
FROM EMP E inner join DEPT D on E.DEPTNO=D.DEPTNO  
           inner join SALGRADE S on E.SAL BETWEEN S.LOSAL AND S.HISAL
WHERE E.DEPTNO=10
	

-- 8. 부서번호가 10번, 20번인 사원들의 부서번호, 부서이름, 
-- 사원이름, 월급, 급여등급을 출력하라. 그리고 그 출력된 
-- 결과물을 부서번호가 낮은 순으로, 월급이 높은 순으로 
-- 정렬하라.
SELECT E.DEPTNO, D.DNAME, E.ENAME, E.SAL, S.GRADE
FROM EMP E inner join DEPT D on E.DEPTNO=D.DEPTNO 
           inner join SALGRADE S on E.SAL BETWEEN S.LOSAL AND S.HISAL
WHERE  E.DEPTNO<=20
ORDER BY E.DEPTNO ASC,  E.SAL DESC

------------------------------------------------------------------------------
--subquery 

-- jones 가 받는 급여보다 더 많은 급여를 받는 사원의 이름과 급여를 출력하세요
select sal from emp where ename='JONES' --2975

select ename , sal 
from emp
where sal > 2975


select ename , sal 
from emp
where sal > (select sal from emp where ename='JONES')

/*
1. 괄호 안에 ..
2. 단독으로 실행 가능
3. 단일컬럼으로 구성  (select sal , deptno ...(x)

실행순서
서브쿼리가 메인쿼리 보다 우선


종류
single row subquery : 결과가 1개의 row  ( > < = >=
multi row subquery  : 결과가 여러 row   (in , not in  , any , all)
구분하는 이유는 사용하는 연산자가 달라요
*/


--직종이 salesman 인 사원들과 같은 급여를 받는 사원들의 사번 , 이름 , 급여정보를 출력하세요
select sal from emp where job='SALESMAN'
--1600 1250 1250 1500
select empno , ename ,sal
from emp
where sal = 1600 or sal = 1250 or sal=1500


select empno , ename ,sal
from emp
where sal in (select sal from emp where job='SALESMAN')
--where sal = 1600 or sal = 1250 or sal=1500

--부서번호가 10번인 사원들과 같은 급여를 받는 사원들의 목록을 출력하세요
select sal from emp where deptno=10

select *
from emp
where sal in (select sal from emp where deptno=10)

--부하직원이 있는 사원의 사번과 이름을 출력하세요
--자신의 사번이 mgr 한번 나오면 ...
select mgr from emp

select *
from emp
where empno in (select mgr from emp)
--empno = 7902 or empno=7788

--부하직원이  없는 사원의 사번과 이름을 출력하세요
--mgr 컬럼에 본인의 사번이 없으면 ... (관리자 아니예요)

select *
from emp
where empno not in (select isnull(mgr,0) from emp)
--empno != 7902 and empno != 7369 and .....null  >> null 과의 연산결과는 >> null

--20번 부서의 사원중에서 급여를 가장 많이 받는 사원보다 더 많은 급여를 받는 모든 사원 정보를 출력하세요

select max(sal) from emp where deptno=20

select *
from emp
where sal > (select max(sal) from emp where deptno=20)


select *
from emp
where sal > ALL(select sal from emp where deptno=20)

-- where sal > data and sal > data and sal > data and...



--20번 부서의 사원중 가장 적은 월급을 받는 사원들보다 더 많은 월급을 받는 사원들의 이름과 월급을 출력하라.
select min(sal) from emp where deptno=20   --800


select *
from emp
where sal > (select min(sal) from emp where deptno=20)

/*
select >  subquery
from   > subquery
where  > subquery


ALL(and)   <>   ANY(or)

*/

select *
from emp
where sal > ANY(select sal from emp where deptno=20)

--where sal > 800 or sal > 2975 or sal > 3000 or sal> 1100 or sal> 3000

--직업이 ‘SALESMAN’인 사원과 같은 [부서]에서 근무하고 같은 [월급]을 받는 사원들의 이름, 월급, 부서번호를 출력하라.




select ename , sal , deptno
from emp
where deptno in (select deptno from emp where job='SALESMAN') 
      and sal in (select sal from emp where job='SALESMAN')
	  --and 컬럼 = ()

--자기 부서의 평균 월급보다 더 많은 월급을 받는 사원들의 이름, 월급, 부서번호, 부서별 평균월급을 구하시오.
--부서별 평균월급을 담고 있는 테이블이 없어요 ... 메모리 잠시 생성 ....  subquery .... from ... 가상테이블
--1. if ... 평균월급을 담고 있는 테이블이 존재한다면
/*
   부서  평균월급
   10   23234
   20   12342
*/
--2.suquery 가 from 절에 사용가능

select deptno , avg(sal) from emp group by deptno

--실무 .... (in line view)
select *
from emp e inner join (select deptno , avg(sal) as avgsal from emp group by deptno) d
on e.deptno = d.deptno
where e.sal > d.avgsal

--TIP)
--단일 (함수) : 여러개 (JOIN) >> 해결 안되면 >> subquery  >> in line view(가상테이블)
--1. 'SMITH'보다 월급을 많이 받는 사원들의 이름과 월급을 출력하라.
SELECT ENAME, SAL
FROM EMP
WHERE SAL>(SELECT SAL
		FROM EMP
		WHERE ENAME='SMITH')

--2. 10번 부서의 사원들과 같은 월급을 받는 사원들의 이름, 월급,
-- 부서번호를 출력하라.
SELECT ENAME, SAL, DEPTNO
FROM EMP
WHERE SAL IN(SELECT SAL
		FROM EMP
		WHERE DEPTNO=10)

--3. 'BLAKE'와 같은 부서에 있는 사원들의 이름과 고용일을 뽑는데
-- 'BLAKE'는 빼고 출력하라.
SELECT ENAME, HIREDATE
FROM EMP
WHERE DEPTNO=(SELECT DEPTNO
		FROM EMP
		WHERE ENAME='BLAKE')
AND ENAME!='BLAKE'

--4. 평균급여보다 많은 급여를 받는 사원들의 사원번호, 이름, 월급을
-- 출력하되, 월급이 높은 사람 순으로 출력하라.
SELECT EMPNO, ENAME, SAL
FROM EMP
WHERE SAL>(SELECT AVG(SAL)
		FROM EMP)
ORDER BY SAL DESC

--5. 이름에 'T'를 포함하고 있는 사원들과 같은 부서에서 근무하고
-- 있는 사원의 사원번호와 이름을 출력하라.
SELECT EMPNO, ENAME
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
		FROM EMP
		WHERE ENAME LIKE '%T%')

--6. 30번 부서에 있는 사원들 중에서 가장 많은 월급을 받는 사원보다
-- 많은 월급을 받는 사원들의 이름, 부서번호, 월급을 출력하라.
--(단, ALL(부정  : and) 또는 ANY(긍정 : or) 연산자를 사용할 것)
SELECT ENAME, DEPTNO, SAL
FROM EMP
WHERE SAL >ALL(SELECT SAL   --max(sal)
		FROM EMP
		WHERE DEPTNO=30)

--7. 'DALLAS'에서 근무하고 있는 사원과 같은 부서에서 일하는 사원의
-- 이름, 부서번호, 직업을 출력하라.
SELECT ENAME, DEPTNO, JOB
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
			FROM DEPT
			WHERE LOC='DALLAS')

--8. SALES 부서에서 일하는 사원들의 부서번호, 이름, 직업을 출력하라.
SELECT DEPTNO, ENAME, JOB
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
			FROM DEPT
			WHERE DNAME='SALES')

--9. 'KING'에게 보고하는 모든 사원의 이름과 급여를 출력하라.
SELECT ENAME, SAL
FROM EMP
WHERE MGR=(SELECT EMPNO
		FROM EMP
		WHERE ENAME='KING')

--10. 자신의 급여가 평균 급여보다 많고, 이름에 'S'가 들어가는
-- 사원과 동일한 부서에서 근무하는 모든 사원의 사원번호, 이름,
-- 급여를 출력하라.
SELECT EMPNO, ENAME, SAL
FROM EMP
WHERE SAL > (SELECT AVG(SAL)
		FROM EMP)
AND DEPTNO IN(SELECT DEPTNO
		FROM EMP
		WHERE ENAME LIKE '%S%')

--11. 커미션을 받는 사원과 부서번호, 월급이 같은 사원의
-- 이름, 월급, 부서번호를 출력하라.
SELECT ENAME, SAL, DEPTNO
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
		FROM EMP
		WHERE COMM IS NOT NULL)
AND SAL IN(SELECT SAL
		FROM EMP
		WHERE COMM IS NOT NULL)

--12. 30번 부서 사원들과 월급과 커미션이 같지 않은
-- 사원들의 이름, 월급, 커미션을 출력하라.
SELECT ENAME, SAL, COMM
FROM EMP
WHERE SAL NOT IN(SELECT SAL
		FROM EMP
		WHERE DEPTNO=30)
AND COMM NOT IN(SELECT ISNULL(COMM, 0)
		FROM EMP
		WHERE DEPTNO=30)

---------------------------------------------------------------------------------
--DML (insert , update , delete) 무조건 암기
--데이터 조작어

--insert ... 실반영
--insert , update , delete ..begin tran ~~~~~ commit 

create table Test(
  userid int
)

insert into Test(userid) values(100) --실반영 

select * from Test

begin tran
  insert into Test(userid) values(200)
rollback
--완료 ,취소 (commit , rollback)
select * from Test

begin tran
  delete from Test
commit  

/*
MSSQL DML 작업에 autocommit 합니다
begin tran
  DML 작성하시면
commit , rollback 서버에 실행

Oracle DML 작업에 대해서 default begin tran

begin tran 생략
insert ..... 
반드시 commit , rollback 실행 ...


 트랜잭션
 transaction
 하나의 논리적인 작업 단위 (성공 or 실패)
 은행업무
 A계좌 B계좌 이체
 여기서 ..
 A = A - 1000

 B = B + 1000
 여기까지 하나의 단위 ...
*/


--insert 
--1. 전체 컬럼에 데이터 삽입

insert into emp(empno ,ename, job, mgr , hiredate, sal , comm, deptno)
values(9999,'홍길동','IT',7902,getdate(),3000,100,10)

select * from emp

insert into emp
values(9991,'홍길동','IT',7902,getdate(),3000,100,10)

select * from emp

--특정 컬럼에 데이터 삽입 (반드시 컬럼명 명시)
insert into emp
values(5555,'아무게',800) --(x)


insert into emp(empno, ename,sal)
values(9992,'아무게',800)

select * from emp order by empno desc


insert into emp(empno , ename, hiredate , deptno)
values(9998 , '깜부' , '2022-01-01',10)

select * from emp order by empno desc

-----------------------------------------------------------------
--update 
/*
UPDATE table_name
SET column_name=value
WHERE search_condition
*/

begin tran
	update emp set sal=0

	select * from emp
rollback

begin tran
	update emp set sal=0 , comm=0 , deptno =100
	where deptno=10
rollback 

	select * from emp where deptno=10

-- 이름이 ‘SCOTT’인 사원의 월급을 0으로 갱신하라.

begin tran
	update emp set sal=0
	where ename='SCOTT'

	update emp set sal=1111
	where deptno=10

	update emp set sal = (select max(sal) from emp)
	where deptno =20
	
rollback
select * from emp order by deptno 

-----------------------------------------
--DELETE 데이터 삭제

--사원번호 7902 데이터 삭제
begin tran
 delete from emp where empno=7902
rollback
select * from emp where empno=7902

begin tran
	delete from emp
rollback
	select *from emp

---------------------------------------
--부가적인 옵션 ...
/*
	select ~ into  (테이블 생성 및 데이터 insert까지)

	insert ~ select(대량 데이터 삽입)
*/

select *
into emp01
from emp
--emp01테이블 만들고 데이터 insert

select * from emp01

select empno , ename ,job ,sal
 into emp02
from emp
where 'A' = 'B'


select * from emp02

---------------------------------------------

insert into emp (empno,ename)
values(1111,'AAA')

--values 대신 select 절사용

insert into emp02(empno , ename ,job ,sal)
select empno , ename,job , sal from emp where deptno=10

select * from emp02

--------------------------------------------------------
--실습

select *
 into empclone
from emp

select * from empclone

delete from empclone

insert into empclone
select * from emp

select * from emp
----------------------------------------------------------------
delete from emp where empno in(9999,9991,9992,9998)
-----------------------------------------------------------------


-- 모든 실습문제는 EMP 테이블의 데이터 보존을 위해 BEGIN TRAN...
-- ROLLBACK TRAN 구문을 사용할 것
use kosaDB
select * 
	into emptest
from emp

select *from emptest

--emptest 로 연습문제 푸세요
-- 모든 실습문제는 EMP 테이블의 데이터 보존을 위해 BEGIN TRAN...
-- ROLLBACK TRAN 구문을 사용할 것

-- 1. EMP 테이블에서 사원번호가 7499번인 사원의 월급을 5000달러로 바꿔라.
BEGIN TRAN 
	UPDATE EMP
	SET SAL=5000
	WHERE EMPNO=7499

	SELECT * FROM EMP	--> 데이터 수정 확인

ROLLBACK TRAN

-- 2. EMP테이블에서 부서번호가 20번인 사원들의 월급을 4000달러로 바꿔라.
BEGIN TRAN

	UPDATE EMP
	SET SAL=4000
	WHERE DEPTNO=20

	SELECT * FROM EMP	--> 데이터 수정 확인

ROLLBACK TRAN

-- 3. DEPT 테이블에 아래의 조건으로 데이터를 입력하라.
-- 부서번호: 50, 부서위치: BOSTON,  부서명: RESERCH
BEGIN TRAN

	INSERT INTO DEPT(DEPTNO, LOC, DNAME)
	VALUES(50,'BOSTON','RESERCH')

	SELECT * FROM DEPT	--> 데이터 입력 확인

ROLLBACK TRAN

-- 4. 사원번호가 7698번인 사원의 부서번호를 7499번 사원의 
--부서번호로 바꿔라.
BEGIN TRAN

	UPDATE EMP
	SET DEPTNO=(SELECT DEPTNO
			FROM EMP
			WHERE EMPNO=7499)
	WHERE EMPNO=7698

	SELECT * FROM EMP	--> 데이터 수정 확인

ROLLBACK TRAN

-- 5. EMP 테이블에 아래와 같은 데이터를 삽입하라.
-- 사원번호: 9900, 사원이름: JACKSON, 직업: SALESMAN, 부서번호: 10
BEGIN TRAN

	INSERT INTO EMP(EMPNO, ENAME, JOB, DEPTNO)
	VALUES(9900, 'JACKSON', 'SALESMAN', 10)

	SELECT * FROM EMP	--> 데이터 입력 확인

ROLLBACK TRAN

-- 6. INSERT...SELECT 문을 이용하여 직업이 'SALESMAN'인
-- 사원의 사원번호, 이름, 직업을 EMP 테이블에 입력하라.
BEGIN TRAN

	INSERT INTO EMP(EMPNO, ENAME, JOB)
		SELECT EMPNO, ENAME, JOB
		FROM EMP
		WHERE JOB='SALESMAN'

	SELECT * FROM EMP	--> 데이터 입력 확인

ROLLBACK TRAN

-- 7. 사원번호가 7369번인 사원과 같은 직업을 가진 사원들의
-- 월급을 7698번 사원의 월급으로 수정하라.
BEGIN TRAN

	UPDATE EMP
	SET SAL=(SELECT SAL
			FROM EMP
			WHERE EMPNO=7698)
	WHERE JOB=(SELECT JOB
			FROM EMP
			WHERE EMPNO=7369)

SELECT * FROM EMP	--> 데이터 입력 확인

ROLLBACK TRAN


-- 8. SCOTT과 같은 직업을 가진 사원을 모두 삭제하라.
BEGIN TRAN

	DELETE FROM EMP
	WHERE JOB=(SELECT JOB
				FROM EMP
				WHERE ENAME='SCOTT')
	SELECT * FROM EMP	--> 데이터 삭제 확인

ROLLBACK TRAN

-- 9. 'SCOTT'의 월급을 'SMITH'의 월급과 같게 수정하라.
BEGIN TRAN

	UPDATE EMP
	SET SAL=(SELECT SAL
			FROM EMP
			WHERE ENAME='SMITH')
	WHERE ENAME='SCOTT'

	SELECT * FROM EMP	--> 데이터 수정 확인
ROLLBACK TRAN

-- 10. 'ALLEN'의 직업을 'SCOTT'의 직업과 같게 수정하라.
BEGIN TRAN

	UPDATE EMP
	SET JOB=(SELECT JOB
			FROM EMP
			WHERE ENAME='SCOTT')
	WHERE ENAME='ALLEN'
	SELECT * FROM EMP
ROLLBACK TRAN

-- 11. 사원번호가 7499번인 사원과 같은 직업을 가진 사원들의
-- 입사일을 오늘날짜로 변경하라.
BEGIN TRAN

	UPDATE EMP
	SET HIREDATE=GETDATE()
	WHERE JOB=(SELECT JOB
			FROM EMP
			WHERE EMPNO=7499)

	SELECT * FROM EMP	--> 데이터 수정 확인

ROLLBACK TRAN

-- 12. SCOTT과 같은 직업을 가진 사원들의 월급을 0으로 수정하라.
BEGIN TRAN

	UPDATE EMP
	SET SAL=0
	WHERE JOB=(SELECT JOB
			FROM EMP
			WHERE ENAME='SCOTT')

	SELECT * FROM EMP	--> 데이터 수정 확인

ROLLBACK TRAN

----------------------------------------------------
--DDL : 정의어 >> create , alter , drop
--1. DB 만들었어요
--2. 그 저장소안에 ... Table 생성 ....

use KosaDB

sp_helpdb kosadb  --DB기본정보 조회하기

--DDL table 생성
create table emp10   -- class Emp10{ public int Empno{get;set;}   }
(
	empno int,
	ename nvarchar(20),
	hirdate datetime
)

/*
char(10)    >> 영문,특수,공백 10자 >> 한글5자  >> 고정길이문자열
varchar(10) >> 영문,특수,공백 10자 >> 한글5자  >> 가변길이문자열

데이터: '남' 또는 '여'
create table T ( gender char(2))   (0)  >> 내부적으로 성능    
create table T ( gender varchar(2)) 

데이터 사람의 이름 : ...이순신 , 김수한무....
create table T (name char(50))  >> 6byte >> 50byte
create table T (name varchar(50)) >> 50byte >> 6byte

영문자한글 ..혼합
unicode
create table T ( gender nchar(4))       개수 4글자 (영문 , 한글 상관없이 4글자)
create table T ( gender nvarchar(4)) 

*/

--테이블 정보

sp_help emp10  --암기

insert into emp10(empno,ename,hirdate)
values(100,'홍길동',getdate())

select * from emp10

create table member2(
 id int,
 name varchar(20),
 address varchar(50),
 birth datetime,
 hobby varchar(100)
)

sp_help member2

insert into member2(id,name,address,birth)
values(1,'이순신','부산시','1960-12-12')

select * from member2
--hobby >> null 


insert into member2(id,name,address,birth,hobby)
values(2,'김유신','부산시','1960-12-12','말타기')

select * from member2

insert into member2(id)
values(3)

select * from member2

--1. 기존테이블에 컬럼 추가하기
alter table member2
add gender char(1)

sp_help member2

--2. 기존테이블에 기존컬럼의 타입변경하기
alter table member2
alter column gender char(2)

sp_help member2

alter table member2
drop column gender

sp_help member2

drop table member2

sp_help member2

create table emp03
(
	empno int not null, --필수입력
	ename varchar(20) -- default null --부가입력
)

insert into emp03(empno) values(7788)

select * from emp03

insert into emp03(ename) values('아무개') --안되요  empno not null (null 허용하지 않아요)

insert into emp03(empno,ename) values(7902,'김유신')

select * from emp03

create table emp04
(
	empno int default 1000,
	ename varchar(20)
)
sp_help emp04  --default 확인

insert into emp04(empno,ename) values(1111,'김씨')

select * from emp04

insert into emp04(ename) values('박씨')
insert into emp04(ename) values('이씨')

select * from emp04

sp_helpconstraint emp04

--DF__emp04__empno__3A81B327 제약이름  (이름을 가지고 나중에 수정,삭제 사용)

create table emp05
(
	empno int constraint df_emp04_empno default 1000,
	ename varchar(20)
)

--df_emp04_empno 관용적 표현 (대부분 개발 관용적 표현)

sp_helpconstraint emp05

create table user02
(
	u_id int not null,
	u_name nvarchar(20),
	u_job  varchar(50) constraint df_user02_u_job default 'IT'
)

sp_helpconstraint user02

insert into user02(u_id, u_name, u_job)
values(10,'홍길동','도적')

select * from user02

insert into user02(u_id, u_name)
values(20,'이순신')

select * from user02

--회원테이블 default ...가입날짜 (getdate())

-------------------------------------------------------------------------
--제약 (constraint)
/*
Data Integrity를 위한 방법 (무결성)

제약의 방법
1. 테이블 생성시 정의하는 방법: CREATE TABLE문 사용
2. 만들어진 테이블에 정의 하는 방법: ALTER TABLE문 사용 **^^


제약의 종류

1. NOT NULL 

2. DEFAULT

3. PRIMARY KEY (not null  + unique) >> 주민번호, 순번, 지문....   한개의 row 반환 받을 수 
                                    >> where num =1 , where jumin=123456-1235467
									>> 검색 .... 속도 향상 ... index ... 
									>> 테이블 1개(묶음) > 1개 , 2개() , 3개() > 복합키

4. UNIQUE  (중복값 허락 안해요)     >> not null 강제하지 않아요
                                    >> 검색  index
									>> 컬럼 수 만큼

5. CHECK (남또는여 들어올수 있어 , 1~10까지만 올수 있어 )  where gender in ('남','여')


6. FOREIGN KEY                      >> Today point (외래키 , 참조키) 참조제약
                                    >> 테이블과 테이블간의 [관계 성립] RDBMS
									>> 관계) 부모 자식 , master  detail 
									>> EMP .... DEPT
									>> Emp deptno 컬럼이 Dept deptno컬럼을 참조 합니다 (FK)
									>> Dept deptno 컬럼은 Emp deptno컬럼에 참조를 당합니다 (PK)

*/
select * from emp
select * from dept

create table emp06
(
  -- empno int primary key,
   empno int constraint pk_emp06_empno primary key,  --pk_emp06_empno
   ename varchar(20)
)
sp_helpconstraint emp06

insert into emp06(empno,ename) values(100,'김유신')

insert into emp06(empno,ename) values(100,'이순신')
--PRIMARY KEY 제약 조건 'pk_emp06_empno'을(를) 위반했습니다. 개체 'dbo.emp06'에 중복 키를 삽입할 수 없습니다. 
--중복 키 값은 (100)입니다.

insert into emp06(ename) values('이순신')
--테이블 'KosaDB.dbo.emp06', 열 'empno'에 NULL 값을 삽입할 수 없습니다. 
--열에는 NULL을 사용할 수 없습니다. INSERT이(가) 실패했습니다.

--테이블당 1개 (묶어서)
--복합키

create table pktable
(
	a int , 
	b int ,
	c int

	constraint pk_pktable_a_b primary key(a,b)
)
--복합키 순서가 
--where b = 10  (문제 ..index(x))
--where a = 10 and b = 20  (good)
--where a = 10 .....

sp_helpconstraint pktable

/*
>>이력테이블

인사테이블
2000 1   IT
2000 2   SALAES


학력테이블
2000  1  인천고
2000  2  인천대


사번 급여월
2000 1
2001 2
2000 2

*/


create table emp07
(
   empno int constraint uk_emp07_empno unique, --중복데이터 허락하지 않아요  --UNIQUE (non-clustered)
   ename varchar(20)
)

sp_helpconstraint emp07

insert into emp07(empno, ename) values(1000,'김씨')
select* from emp07

insert into emp07(ename) values('김씨')
insert into emp07(ename) values('박씨')
--UNIQUE KEY 제약 조건 'uk_emp07_empno'을(를) 위반했습니다. 개체 'dbo.emp07'에 중복 키를 삽입할 수 없습니다. 
--중복 키 값은 (<NULL>)입니다.

create table emp08
(
   empno int not null constraint uk_emp09_empno unique, --중복데이터 허락하지 않아요  --UNIQUE (non-clustered)
   ename varchar(20)
)

-- 그러면  empno int not null constraint uk_emp09_empno unique >> primary key 같은 거 아니야 

create table emp09
(
	u_id int constraint pk_emp09_u_id primary key,
	u_name varchar(20) not null,
	reg_num1 char(6) not null constraint uk_emp09_reg_num1 unique,
	reg_num2 char(7) not null constraint uk_emp09_reg_num2 unique,
	u_job nvarchar(20) constraint df_emp09_u_job default 'IT'
)

sp_helpconstraint emp09


create table emp11
(
  empno int constraint pk_emp10_empno primary key,
  ename varchar(20) not null,
  gender char(2) constraint ck_emp10_emp10_gender check(gender in ('남','여'))
)
--([gender]='여' OR [gender]='남')
sp_helpconstraint emp11

insert into emp11(empno,ename,gender) values(1000,'김','중')
--INSERT 문이 CHECK 제약 조건 "ck_emp10_emp10_gender"과(와) 충돌했습니다. 
--데이터베이스 "KosaDB", 테이블 "dbo.emp11", column 'gender'에서 충돌이 발생했습니다.

insert into emp11(empno,ename,gender) values(1000,'김','남')

--참조제약--------------------------------------
select * from emp

select * from dept

--MSSQL 서는 not null 하지 않은 컬럼에 대해서 ..PK 걸지 못해요
alter table dept
alter column deptno int not null


alter table dept
add constraint pk_dept_deptno primary key(deptno)

alter table emp
add constraint fk_emp_deptno foreign key(deptno) references dept(deptno)

--참조되는 테이블 'dept'에 외래 키 'fk_emp_deptno'의 참조 열 목록과 일치하는 기본 키 또는 후보 키가 없습니다.
--반드시 참조하는 테이블에 PK 선행되어야 한다


--옵션
--identity(증가분)
--채번 (번호표) 
--sequence (객체 번호표) : oracle ,mssql

create table board(
  boardid int identity(1,1),
  title varchar(20)
)

insert into board(title) values('방가')

select * from board;

create table emp20
(
	a int ,
	b int ,
	c as a+b --계산된 열
)

insert into emp20(a,b) values(100,300)
select * from emp20

-------------------------------------------------------------------
--VIEW (가상테이블)
--혹자는 : SQL 문장 덩어리

--View  객체 (create ... drop  전까지는)

create view tbl_emp
as
   select empno , ename, job, deptno from emp

--사용법 : 가상 테이블 >> 테이블처럼 >> 뷰를 통해서 

select * from tbl_emp --view가지는 SQL문장 실행
select * from tbl_emp where deptno=10 -- view를 통해서 볼수 있는 데이터 ...가지고 놀 수 있다

sp_help tbl_emp
--tbl_emp	dbo	 view	2022-03-24 14:47:57.450
sp_helptext tbl_emp

--편리성 (쿼리 단순화 >> 물리적인 테이블이 없는 경우 >> view 가상테이블 만들어서 >> JOIN)
create view v_emp  --부서번호 , 부서이름 ,사번 ..... 매번 join
as
	select empno , ename ,e.deptno, dname
	from emp e inner join dept d
	on e.deptno = d.deptno

select * from  v_emp

--결과) 기존에 배운 쿼리를 다 알고 있다면 view 공짜

--직업이 salesman인 사람들의 이름 , 월급 , 직업만 보여주는 view  작성하세요

	select ename, sal, job
	from emp 
	where job='SALESMAN'

	create view v_emp2
	as
	  select ename, sal, job
	  from emp 
	  where job='SALESMAN'


  select * from v_emp2

  --부서번호가 30번이 사원의 이름, 급여, 부서번호 를 보여주는 View작성하세요

  create view v_emp3
  as
    select ename, sal , deptno 
	from emp
	where deptno=30

	select * from v_emp3

--view도 테이블면 dml 작업
--view [통해서] 원본테이블에서 view가 볼수 있는 것만 insert , update , delete작업 가능 하다
--그러나 하지 마세요

select * from v_emp3

begin tran
	update v_emp3
	set sal = 0
rollback

select * from emp
select * from v_emp3

--부서별 평균 월급을 담고 있는view 를 작성하라
--subquery   from (select deptno , avg(sal) as svgsal from emp....) e)

create view empavg
as
  select deptno , avg(sal)as avgsal from emp group by deptno

 select *
 from emp e join empavg s on e.deptno = s.deptno and e.sal > s.avgsal

 --1. 편리성 (복잡한 쿼리(조인) ..view 만들어서) 편하게
 --2. 가상 테이블 (원하는 데이터를 만들어서) join 같은 것 처리

 -- 사원테이블에서 이름과 월급만 담는 VIEW를 작성하되, 월급이 높은 순으로 출력하라.
 -- view 생성시 order by 사용하지 마세요
 create view view001
 as
   select top 20 ename , sal from emp order by sal desc

select * from view001

--1. 30번 부서 사원들의 직위, 이름, 월급을 담는 VIEW를 만들어라.
CREATE VIEW VIEW100
AS
	SELECT JOB, ENAME, SAL
	FROM EMP
	WHERE DEPTNO=30
SELECT * FROM VIEW100

--2. 30번 부서 사원들의  직위, 이름, 월급을 담는 VIEW를 만드는데,
-- 각각의 컬럼명을 직위, 사원이름, 월급으로 ALIAS를 주고 월급이
-- 300보다 많은 사원들만 추출하도록 하라.
CREATE VIEW VIEW101
AS
	SELECT JOB AS '직위', ENAME AS '사원이름', SAL AS '월급'
	FROM EMP
	WHERE DEPTNO=30 AND SAL > 300
SELECT * FROM VIEW101

--4. 부서별 평균월급을 담는 VIEW를 만들되, 평균월급이 2000 이상인
-- 부서만 출력하도록 하라.
CREATE VIEW VIEW103
AS
	SELECT DEPTNO, AVG(SAL) AS '평균월급'
	FROM EMP
	GROUP BY DEPTNO
	HAVING AVG(SAL) >=2000

SELECT * FROM VIEW103


-------------------------------------------------------------------------
use KosaDB

sp_who2

begin tran
	update emp set sal=0

	select * from emp
rollback



select rownum , empno
from  (
		select row_number() over (order by empno) as rownum , empno
		from emp
      ) T where t.rownum between 1 and 5  --pagesize=5


select row_number() over (order by empno asc) as rownum , empno
from emp


select empno ,ename
from emp
order by empno offset 0 rows fetch next 5 rows only

select empno , ename
from emp
order by empno offset 5 rows fetch next 5 rows only


select empno , ename
from emp
order by empno offset 10 rows fetch next 5 rows only


with T(deptno,total)
as
    (select deptno , sum(sal+isnull(comm,0)) from emp group by deptno)
select * from T order by total desc;


--DATETIME 데이터 타입을 가지는 @ymd 변수를 선언하고,
--이 변수에 GETDATE()함수를 사용하여 현재 날짜시간을 저장한 다음 화면에 출력하라.

DECLARE @ymd datetime
SET @ymd=GETDATE()
SELECT @ymd

--INT 데이터 타입을 가지는 @sal 변수를 선언하고, 
--이 변수에 5000이라는 초기값을 담도록 지정하라. 
--그리고 EMP 테이블에서 월급이 @sal인 사원의 이름과 월급을 출력하라.
DECLARE @sal int
SET @sal=5000
	SELECT ENAME, SAL
	FROM EMP
	WHERE SAL=@sal

--EMP 테이블로부터 평균월급을 담는 변수를 선언하고, 
--이 변수를 이용해 평균월급보다 더 많은 월급을 받는 사원의 모든 정보를 출력하는 쿼리문을 작성하라.

DECLARE @avg int
SET @avg=(SELECT AVG(SAL) FROM EMP)
	SELECT *
	FROM EMP
	WHERE SAL>@avg

--Q1. 변수 @i에 임의의 값을 설정하고 @i의 값이 100보다 작을 경우와 
--100이상일 경우를 나누어 출력 메시지를 다르게 뿌리는 
--IF…ELSE문을 작성하라.

declare @i int
set @i = 250
if @i < 300
	select convert(varchar(10),@i) + ' 은 보다 작습니다' 
else
    select convert(varchar(10),@i) + ' 은 보다 큽니다' 

--begin ~ end  블럭
declare @sal int
set @sal = 2000
if @sal >= 3000
	begin
		print '월급이 3000달러 이상인 사원들'
		select *
		from emp
		where sal >= 3000
	end
else
	begin
		print '월급이 3000달러 미만인 사원들'
		select *
		from emp
		where sal <  3000
	end
/*
if(){}else{}

 declare
 set
 if
	begin

	end
 else
    begin

	end

*/

--case  ~  when  ~ then

select empno , ename , job , deptno , 
       ( 
	     case deptno when 10 then 'A'
	                 when 20 then 'B'
					 when 30 then 'C'
					 when 40 then 'D'
         else  
		     '방가방가'
         end
	   ) as '하나의 컬럼' , 111 as '데이터1',222 as '데이터2',333 as '데이터3' , null as '데이터4'
from emp



select empno , ename , job , deptno , 
       ( 
	     case 
			when deptno = 10 then 'AA'
	        when deptno between 20 and 30 then 'BB'
			when deptno in (40,50) then 'CC'
         else  
		     '방가방가'
         end
	   ) as '하나의 컬럼' , 111 as '데이터1',222 as '데이터2',333 as '데이터3' , null as '데이터4'
from emp


--while  1~10까지의 합
declare @i int , @sum int
set @i = 1
set @sum = 0
while @i <= 10
	begin
		set @sum = @sum + @i
		set @i = @i + 1
	end
select @sum
/*
while(i <= 10)
{
  sum+=i;
  i++;
}
*/

------------------------------------------------------
--프로시져
--장점
--보안 , 성능 , 관리 

create proc myproc
as
  select empno ,ename from emp

exec myproc

alter proc myproc
as
  select empno, ename , job , sal from emp


exec myproc

drop proc myproc


sp_helptext myproc


create proc myproc1
as
  update emp 
  set sal=0

begin tran
   exec myproc1
   select * from emp
rollback

--프로시져 이름
--시스템 ...프로시져
--sp_help

--usp_emplist

create proc usp_empAllList
as
  select empno , ename , sal
  from emp

exec usp_empAllList

create proc usp_empUpdateSal
as
  update emp
  set sal = sal *2

begin tran
	exec usp_empUpdateSal

	select *from emp
rollback 

--* input 매개변수 사용 가능
create proc myproc3
@i int  -- input
as
  select *
  from emp where empno = @i

exec myproc3 7788

exec myproc3 7902

create proc myproc4
@i int
as
   update emp
   set sal = sal *@i

begin tran
	exec myproc4 100

	select * from emp
rollback

--begin tran
--	exec myproc4  --프로시저 또는 함수 'myproc4'에 매개 변수 '@i'이(가) 필요하지만 제공되지 않았습니다.

alter proc myproc4
@i int = 2  --default
as
   update emp
   set sal = sal *@i

create proc myproc5
@sal int,
@deptno int
as
   select *
   from emp
   where sal < @sal and deptno = @deptno

exec myproc5 4000,20


use pubs
/*
 Pubs DB의 title라는 테이블에서 책 이름과 그 책의 가격을 가져오는 MYPROC6라는 프로시저를 만들어라. 
 그리고 책 이름과 책의 가격은 사용자로부터 입력받도록 할 것이며, 
 값을 입력하지 않았을 경우 default값으로 각각 ‘%’와 NULL로 출력되도록 지정하여라.
 */

alter proc myproc6
	@title varchar(50) = '%',
	@price money =null
as
   if @price is null
		begin
			select title , price 
			from titles
			where title like @title  -- title like '%'
		end 
    else
		begin
			select title , price 
			from titles
			where title like @title and price = @price
		end

exec myproc6
exec myproc6 '%Can%'	
exec myproc6 @price =19.99  --특정 파라메터 .. 변수면 @price
exec myproc6 '%talk%',19.99
exec myproc6 @price=19.99 ,@title='%talk%'  --Straight Talk About Computers	19.99

--시스템 프로시져
sp_tables 
sp_help titles
sp_helpdb
select * from titles

--input , output
create proc myproc7
@a int,
@b int,
@c int output 
as
	set @c = @a + @b
	print @c


exec myproc7 10 , 20  --프로시저 또는 함수 'myproc7'에 매개 변수 '@c'이(가) 필요하지만 제공되지 않았습니다.

declare @out int
exec myproc7 10,20,@out output
select @out
--처음 입력한 숫자에 30을 더한 후, 더한 값에 두 번째 숫자를 곱한 값을 출력하는 프로시저를 작성하라.


CREATE PROC MYPROC8
@a int, @b int, @c int output
AS
SET @c=(@a+30)*@b

declare @out int
exec myproc8 10,20,@out output
select @out as '결과값'

create proc myproc9
@a int,
@b int,
@c int output,
@d int output
as
	set @c = @a + @b
	set @d = @a * @b

declare @out_1 int , @out_2 int
exec myproc9 10 , 20 , @out_1 output , @out_2 output
select @out_1 as 'data_1' , @out_2 as 'data_2'

--output 말고 return  사용도 가능
use KosaDB;
create proc myproc10
as
    declare @count int
	set @count = (select count(*) from emp)
	return @count

declare @return int
exec @return = myproc10
select @return

--return 되는 값의 유무에 따라 로직 제어
--데이터 존재 유무
create proc myproc11
@empno int
as
	declare @exist bit
	select @exist = count(*) from emp where empno=@empno
	if @exist > 0
	   begin
		  return 1
	   end
     else
	   begin
	     return -1
	   end

declare @exist int
exec @exist = myproc11 7788
select @exist

declare @exist int
exec @exist = myproc11 1000
select @exist


create proc usp_dept_insert
@deptno int,
@dname varchar(20),
@loc varchar(20)
as
	declare @err int

	begin try
		insert into dept(deptno , dname, loc)
		values(@deptno , @dname , @loc)
	end try
	begin catch
		set @err = @@error
	end catch

	return @err

sp_helpconstraint dept

/*

alter table dept
alter column deptno int not null


alter table dept
add constraint pk_dept_deptno primary key(deptno)

alter table emp
add constraint fk_emp_deptno foreign key(deptno) references dept(deptno)

*/



