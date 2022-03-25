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
DDL(Data Definition Language): ������ ���� ���, �����ͺ��̽� ��ü�� ����/����/������ �������� ����ϴ� ���
Create ...

Alter ...

Drop ...


DCL(Data Control Language): ������ ���� ���, ������ ��� �����ϰ� ����ϴ� ���, ���� �����͸� ������ �� �ִ����� �����ϴ� ���.
DB������
Grant .. ���

Revoke ..Grant �ߴٰ� ... 

Deny  ���� ���� ...



DML(Data Manipulation Language): ������ ���� ���, ������ ��ü�� ó���ϰ� �����ϱ� ���� ���
������ ....
select (60%) >> �Լ� , ���� , �������� , ��...

insert 

update

delete

*/

select * from emp;

select * from dept;

select * from salgrade;

--1. ��� ���̺� �ִ� ��� ��������͸� ����ϼ���
select *
from emp;

--2. Ư�� �÷�(��� , �̸� , �޿�) �� ����ϼ���
select empno , ename , sal from emp;

--3. �μ����̺��� �ִ� �μ���ȣ , �μ��̸� ����ϼ���
select deptno , dname from dept;

--4. �����ȣ , ����̸� �÷����� ��½� �ѱ۷� ...
select empno �����ȣ , ename ����̸� from emp;

select empno as '��� ��ȣ' , ename as '��� �̸�' from emp;

--5. ������̺��� ������ ����ϼ���
--�츮ȸ�翡 ������ ��� ���� ...
--�ߺ��� �� ���� ���
select job from emp;

select distinct job from emp;

--SQL (���) ���Ǹ� �� �� �ִ� ���
--������ 
--1.��� , �� , ��

--6. ������̺��� ���, �̸� , �޿� , 300�޷� �λ�� �޿��� ����ϼ���
select * from emp;

select empno , ename , sal , sal + 300 as '�λ�޿�' from emp;

--7. ������̺��� ��� , �̸� , �޿� , ����(�޿� *12)�� ����ϼ���
select * from emp;

select empno, ename, sal , sal * 12 as '����' from emp;

--8. Null (�ʿ��)
--ȸ�� ���̺� ... ȸ����ȣ , ȸ���� , �ڵ��� , ���  (�ʼ� �Է� , �ɼ� null )
select * from emp;

select empno , sal , comm from emp;
--comm ������ null >> comm �� ���� �ʴ� ����
--7844	1500	0 ���� �ʴ� �������� ������ Ȯ�� .....

--9 ��� ���̺��� ��� , �̸� , ���� , �޿� , ���� , �޿�+������ ����ϼ���
select empno , ename , job , sal , comm , sal + comm as '�ѱ޿�' from emp;

-- POINT > Null ���� ��� ������ �����  >> Null
--Null ó���ϴ� �Լ� .....
--Oracle : nvl()     >> select nvl(comm,0)
--Mysql  : ifnull()  >> select ifnull(comm,0)
--Mssql  : isnull()
select sal + isnull(comm,0) from emp;

select sal + isnull(comm,11111) from emp;


select empno , ename , job , sal , comm , sal + isnull(comm,0) as '�ѱ޿�' from emp;


/*
�������
select   3
from     1 
where    2

*/
--������̺��� ����� 7788�� ����� ��� , �̸� ,�޿��� ����ϼ���
select empno , ename , sal
from emp
where empno=7788;

--������̺��� ����̸��� SMITH �� ����� ��� ������ ����ϼ���
select *
from emp
where ename ='smith';

select *
from emp
where ename ='SMITH';

--Oracle �� ���ڿ� ������ ��ҹ� �����ϰ� ����
--where ename ='smith';  �ȳ��Ϳ�
--where ename ='SMITH';  ����̵ǿ� 

--������̺��� �Ի��� 1980�� 12�� 17���� ����� ��� ������ ������ ����ϼ���
--��¥ �����͵� ���ڿ� ó�� '' ����ؼ� ó��
select * from emp
where hiredate ='1980-12-17';



select * from emp
where hiredate ='1980/12/17';

select * from emp
where hiredate ='80/12/17';

--������  salesman �� ����� ��� , �̸� ,�޿� ,������ ����ϼ���
select empno , ename,  sal , job
from emp
where job = 'SALESMAN';

--�μ���ȣ�� 10�� ����� �μ���ȣ , �̸� , �޿� ������ ����ϼ���
select deptno , ename , sal
from emp
where deptno = 10;

--�� ����
--������̺��� �޿��� 3000�̻��� ����� �̸��� �޿��� ����ϼ���
select ename , sal
from emp
where sal >= 3000;

--������̺��� ������ salesman �� �ƴ� ����� ��� , �̸� , ������ ����ϼ���
select *
from emp
where job != 'SALESMAN';

select *
from emp
where job <> 'SALESMAN'; --����


--������̺��� ������ 3000 �̻��� ����� ��� , �̸� , �޿� , ������ ����ϼ���
select empno , ename , sal , sal*12 as '����'
from emp
where (sal * 12) >= 3000;


use KosaDB;

--������ salesman �̰� �޿��� 2000�̻��� ����� ��� , �̸� , �޿� , ������ ����ϼ���
--and 
select * from emp
where job = 'SALESMAN' and sal >= 1500;


--������ salesman �̰ų� �޿��� 2000�̻��� ����� ��� , �̸� , �޿� , ������ ����ϼ���
select * from emp
where job = 'SALESMAN' or sal >= 1500;


--������̺��� �޿��� 1000�̻� 3000������ ����� ���, �̸� ,�޿��� ����ϼ���
select *
from emp
where sal >= 1000 and sal <= 3000;

--between A and B  (=�� ����)
select *
from emp
where sal between 1000 and 3000;

--������̺��� �޿��� 1000�ʰ� 3000�̸��� ����� ���, �̸� ,�޿��� ����ϼ���
select *
from emp
where sal > 1000 and sal < 3000;

--������̺��� ����� 7788 , 7902 , 7369 �� ����� ����� �̸��� ����ϼ���
select *
from emp
where empno=7788 or empno=7902 or empno=7369;

--in ������ 
select *
from emp
where empno in (7788,7902,7369);

--������̺��� ����� 7788 , 7902 , 7369 �� �ƴ� ����� ����� �̸��� ����ϼ���

select *
from emp
where empno not in (7788,7902,7369);

--Like ������ (���� : ���ڿ�)



--like  �����ڸ� �����ִ� wild card
--% ��� ��  (�ƹ��͵� ���� ���)
--_ �ѹ���
--[] �ȿ� �ִ� ����
--[^] ������ �ִ� ���� ����

--������̺��� �̸��� S�� �����ϴ� ����� ����� �̸��� ����ϼ���
select * 
from emp
where ename like 'S%';

--�̸��� �ι�° ���ڰ� A�� ����� ����� �̸��� ����ϼ���
select *
from emp
where ename like '_A%'; --�ι�° 
/*
WARD
MARTIN
JAMES

*/

--�̸��� T �� �ι� ����ִ� ���
-- TT ,  ATAT
select *
from emp
where ename like '%T%T%'

--SCOTT

--�̸��� ù���ڰ� A , B , S �� �����ϴ� �������

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

--�̸��� ù���ڰ� A or S �����ϰ� �ι�° ���ڰ� C�� �ƴ� ���
select *
from emp
where ename like '[AS][^C]%'

----------------------------------------------------------------------------------
--QUESTION
--1. ������̺��� ��� �����͸� ����϶�
select *
from emp

--2. ������̺��� �����ȣ, ����̸�, ������ ����϶�
select empno, ename, sal
from emp

--3. ������̺��� ������ �̴µ� �ߺ��� �����Ͱ� ���� ����϶�
select distinct sal
from emp

--4. ������̺��� ����̸��� ������ ����ϴµ� ������ �÷�����
-- '�� ��','�� ��'���� �ٲ㼭 ����϶�. ��, ALIAS�� �����߰�
select ename as '�� ��', sal as '�� ��'
from emp

--5. ������̺��� ����̸�, ������ �̰�, ���ް� Ŀ�̼���  ���� ����
-- ����ϴµ� �÷����� '�Ǳ޿�'�̶�� �ؼ� ����϶�.
-- ��, NULL���� ��Ÿ���� �ʰ� �϶�.
select ename, sal, sal+isnull(comm,0) as '�Ǳ޿�'
from emp

--6. ������̺��� 'SCOTT'�̶�� ����� �����ȣ, �̸�, ������ ����϶�
select empno, ename
from emp
where ename='SCOTT'

--7. ������̺��� ������ 'SALESMAN'�� ����� �����ȣ, �̸�, ������
-- ����϶�
select empno, ename, job
from emp
where job='SALESMAN'

--8. ������̺��� �����ȣ�� 7499, 7521, 7654�� ����� �����ȣ, �̸�
-- ������ ����϶�
select empno, ename, sal
from emp
where empno in(7499,7521,7654)

--9. ������̺��� ������ 1500���� 3000������ ����� �����ȣ, �̸�,
-- ������ ����϶�.
select empno, ename, sal
from emp
where sal between 1500 and 3000

--10. ������̺��� �̸��� ù���ڰ� A�̰� ������ ���ڰ� N�� �ƴ� �����
-- �̸��� ����϶�
select ename
from emp
where ename like 'A%[^N]'



create table Tlike(
   col1 int,
   col2 varchar(10) --10byte  (�ѱ� 5�� , ������, Ư������ ,���� 10��)
)
--class Tlike { private int col1, private string col2}
insert into Tlike(col1, col2) values(10,'10')
insert into Tlike(col1, col2) values(20,'10%')
insert into Tlike(col1, col2) values(30,'20')

select * from tlike

select * from tlike where col2 like '%10%'

--'10%' �˻�
select * from tlike where col2 like '%10E%%' ESCAPE 'E'
--ESCAPE 'E' ��� ���� �ڿ��� ����������  >> 10E%

--Today Point
--������̺��� Ŀ�̼�(����)�� å���Ǿ� ���� ���� (���� �ʴ�)
--����� �̸��� Ŀ�̼��� ����ض�( �� comm > 0 �ΰ� �޴°����� ����)


--select * from emp where comm = null; ������ �����
--null ������ 
--1. is null
--2. is not null

select * from emp where  comm is null

--������ �޴� �������
select * from emp where comm is not null

--�Լ�
--�����Լ� , �����Լ� , ��¥�Լ� , ����Լ� ,�ý��� �Լ� ...

--1. �����Լ�
select lower('ABC')
select upper('abc')

select upper(ename) as 'ename' from emp

select 100+100+100
select ename + 'is a ' + job from emp -- + ���� or ����(���ڿ�) 

select substring('abcd',1,3)
select substring('abcd',3,1)  -- 1 �ڱ��ڽ�

select left('abcd',3)
select right('abcd',3)

--������̺��� ����� �̸����� ù���ڴ� �빮�ڷ� �������� �ҹ��ڷ� ����ϼ���
--a().b().c() ü�� (x) SQL��
--a(b(c()))

select upper(left(ename,1)) + lower(substring(ename,2,20)) as 'ename' from emp 

select upper(left(ename,1)) + lower(substring(ename,2,len(ename))) as 'ename' from emp 

select len('abcd')
select len(ename) from emp

select len('a       b')
select len('     a')
select len('a         ')-- len�Լ��� ������� ���� ���Ѵ�

select datalength('abc')  -- 3byte
select datalength('ȫ�浿') --6byte


--��������
select '>' +  '     a' + '<'
-->     a<

select '>' +  ltrim('     a') + '<'
-->a<
select '>' +  rtrim('a      ') + '<'


select '>' +  rtrim(ltrim('     a     ')) + '<'

--replace
select replace('abcd','a','NEWNEW')

--'ȫ      ��     ��'
select '>' + 'ȫ      ��     ��' + '<'
--������ ���ʿ� ����
--��� 'ȫ�浿'

select replace('ȫ      ��     ��',' ','')
--ȫ�浿

--�����Լ�
select round(123.45,1) --123.50   �ݿø� �Լ�
select round(123.45,2) --123.45 
select round(123.45,0) --123
select round(123.55,0) --124.00

select power(2,4)

--CEILING: ������ ���ں��� ū �ּ� ������ ��ȯ�Ͽ� ���
SELECT CEILING(1234.5678), CEILING(123.45), CEILING(-1234.56)


--FLOOR: ������ ���ں��� ���� �ִ� ������ ��ȯ�Ͽ� ���
SELECT FLOOR(1234.5678), FLOOR(123.45), FLOOR(-1234.56)
--1234	123	-1235

--��¥ �Լ� 
select getdate() -- 2022-03-22 14:46:16.767

--Oracle : select sysdate
select dateadd(yy,10,getdate())
select dateadd(mm,5,getdate())
select dateadd(dd,100,getdate())

select dateadd(yy,10,'2022-01-01')

select datediff(yy,'2010-12-12','2022-01-13')
select datediff(mm,'2010-12-12','2022-01-13')
select datediff(dd,'2010-12-12','2022-01-13')

--�� ������ ���� 30�ϱ��� 
select ename, 
         datediff(dd,hiredate,getdate()) / 365  as '��',
         (datediff(dd,hiredate,getdate()) % 365)/30 as '����',
          (datediff(dd,hiredate,getdate()) % 365) % 30 as '��'
from emp


--���ú��� ���� 12-31�ϱ��� ���� ���ҳ���
select datediff(dd, getdate(),'2022-12-31')

select year(getdate())
select month(getdate())
select day(getdate())

--���� , ���� , ��¥ �Լ� �⺻���� ���

--����ȯ �Լ� (Today Point)
select convert(int,'100') + 100
select convert(int,'100A') + 100  --varchar �� '100A'��(��) ������ ���� int(��)�� ��ȯ���� ���߽��ϴ�.

--����Ŭ select * from dual;

select convert(varchar(20),sal) + '�޿��Դϴ� '
from emp

select ename  + ' �� �����' + convert(varchar(20),empno) + ' �Դϴ�' as 'fullname'
from emp

--�����Լ� 
--sum() , avg() , max() , min() , count()

select sum(sal) from emp
select avg(sal) from emp
select max(sal) from emp
select min(sal) from emp
select count(empno) from emp

/*
1. �����Լ��� null ���� �����Ѵ� (�� count(*) ����)
2. select ���� �����Լ� �̿ܿ� �ٸ� �÷��� ���� �ݵ�� �� �÷��� group by���� ��õǾ�� �Ѵ�
*/

select comm from emp  --14
select count(comm) from emp --null ����
select comm from emp where comm is not null

--comm ���
select avg(comm) from emp  --721  �츮ȸ��� �޴� ������� ���� ... �����Լ��� null����
--�츮ȸ��� ������� ���� ...
--�츮ȸ��� �޴� ������� ���� 
select (300 + 200 + 30 + 300 + 3500 + 0) /6  --721
select (300 + 200 + 30 + 300 + 3500 + 0) /14 --309

--�츮ȸ��� ������� ���� ...
select avg(isnull(comm,0))  from emp  --309  ---Today POINT

--�����Լ��� ����� 1��
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
order by        5  ����  (select �� ����)

*/

--������ ��տ����� ���ϵ� �÷� ����Ī�� '���'  ��տ����� ���� ������ �����͸� �����ϼ���
select job , avg(sal) as '���'
from emp
group by job
order by ��� desc 

--mssql Top n ����
--������̺��� ������ ���� ���� �޴� ��� 5���� �̸��� �޿��� ����ϼ���

select top 5 ename , sal
from emp
order by sal desc


select top 2  with ties ename , sal  --���� ó���ϱ� 
from emp
order by sal desc

select top 50 percent ename, sal
from emp
order by sal desc

--������ �ѿ����� ���ϰ� �ѿ����� 5000�̻��� ��� ��������͸� ����ϼ���

--from ���� ������  where
--group by ���� ������ having 

--�������̺� (��� ����)
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

--�μ��� ������ ���� ���ϰ� �� ������ 10000�̻��� ��� �����͸� ����ϼ���

select deptno , sum(sal) as 'sumsal'
from emp
group by deptno
having sum(sal) >= 10000

--�μ��� �ѿ����� ���ϵ� 30���μ��� �����ϰ�, 
--�� �ѿ����� 8000�޷� �̻��� �μ��� �������ϰ�, 
--�ѿ����� ���� ������ ����϶�.
select deptno , sum(sal) as 'sumsal'
from emp
where deptno != 30
group by deptno
having sum(sal) >= 8000
order by sumsal desc


--�μ��� ��տ����� ���ϵ� Ŀ�̼��� å���� ����� ��������, 
--�� ��տ����� 2000�޷� �̻��� �μ��� �������ϰ�, 
--��տ����� ���� ������ ����϶�
select deptno , avg(sal) as 'avgsal'
from emp
where comm is not null
group by deptno
having avg(sal) >=2000
order by avgsal desc


--QUESTION
--1. ��� ���̺��� ����̸��� ù���ڴ� �빮�ڷ�, �������� �ҹ��ڷ� ����϶�
SELECT UPPER(LEFT(ENAME,1))+LOWER(SUBSTRING(ENAME,2,8))
FROM EMP

--2. ������̺��� ����̸��� �̰� �� �̸��� �ι�° ���ں��� �׹�° ���ڱ���
-- ����϶�.
SELECT ENAME, SUBSTRING(ENAME,2,3)
FROM EMP

--3. ������̺��� ��� �̸��� ö�� ������ ����϶�.
SELECT LEN(ENAME)
FROM EMP

--4. ������̺��� ��� �̸��� �� ���� �ϳ��� ������ ���� �ϳ��� ����ϵ� 
-- ��� �ҹ��ڷ� ���� ����϶�.
SELECT LOWER(LEFT(ENAME,1)), LOWER(RIGHT(ENAME,1))
FROM EMP

--5. 3456.78�� �Ҽ��� ù��° �ڸ����� �ݿø��϶�.
SELECT ROUND(3456.78, 0)

--6. 3�� 4������ ���ϰ�, 64�� �������� ���϶�.
SELECT POWER(3,4), SQRT(64)
-->: �������� �Ҽ��� ���Ϸ� ��Ÿ�� �� �ֱ� ������ float������ ��µȴ�.

--7. ���ó�¥�� ���ó�¥���� 10���� ���� ��¥�� ����϶�.
SELECT GETDATE(), DATEADD(DD,10,GETDATE())
--OR
SELECT GETDATE(),GETDATE()+10

--8. ���� ǥ������ ���� ��¥�� ����϶�.
SELECT CONVERT(VARCHAR(20), GETDATE(), 112)

--9. ������̺��� ����̸��� ������� ���� ��¥������ �ٹ��ϼ��� ���϶�.
SELECT ENAME, DATEDIFF(DD, HIREDATE, GETDATE())
FROM EMP

--10. �� �������� �ٹ��ϼ��� 00�� 00���� 00�� �ٹ��Ͽ�����
--Ȯ���� �� �ֵ��� ��ȯ�϶�.(��, �� ���� 30�Ϸ� ����϶�)
-- ��)
--  | ENAME	| �ٹ��ϼ�		|
--  | KING	| 00�� 00���� 00��	|

SELECT ENAME,
CONVERT(VARCHAR(20),DATEDIFF(DD, HIREDATE, GETDATE())/365)+'�� '+
CONVERT(VARCHAR(20),DATEDIFF(DD, HIREDATE, GETDATE())%365/30)+'���� '+
CONVERT(VARCHAR(20),DATEDIFF(DD, HIREDATE, GETDATE())%365%30)+'��'
FROM EMP



--1. ������̺��� �μ��� �ִ� ������ ����϶�.
SELECT DEPTNO, MAX(SAL)
FROM EMP
GROUP BY DEPTNO

--2. ������̺��� ������ �ּ� ������ ���ϵ� ������ 
-- CLERK�� �͸� ����϶�.
SELECT JOB, MIN(SAL)
FROM EMP
WHERE JOB='CLERK'
GROUP BY JOB

--3. Ŀ�̼��� å���� ����� ��� �� ���ΰ�?
SELECT COUNT(COMM)
FROM EMP

--4. ������ 'SALESMAN'�̰� ������ 1000�̻��� �����
-- �̸��� ������ ����϶�.
SELECT ENAME, SAL
FROM EMP
WHERE JOB='SALESMAN' AND SAL>=1000

--5. �μ��� ��տ����� ����ϵ�, ��տ����� 2000����
-- ū �μ��� �μ���ȣ�� ��տ����� ����϶�.
SELECT DEPTNO, AVG(SAL)
FROM EMP
GROUP BY DEPTNO
HAVING AVG(SAL)>=2000

--6. ������̺��� Ŀ�̼��� ���� ���� �޴� ��� 2����
-- ����ϵ� ��ŷ�� �ߺ��� ��� ����ó���� �Ͽ� ����϶�.
SELECT TOP 2 WITH TIES ENAME, COMM
FROM EMP
ORDER BY COMM DESC

--7. ������ MANAGER�� ����� �̴µ� ������ ���� ���
-- ������ �̸�, ����, ������ ����϶�.
SELECT ENAME, JOB, SAL
FROM EMP
WHERE JOB='MANAGER'
ORDER BY SAL DESC

--8. �� �������� �ѿ����� ����ϵ� ������ ���� ������
-- ����϶�.
SELECT JOB, SUM(SAL) 
FROM EMP
GROUP BY JOB
ORDER BY SUM(SAL) --OR ORDER BY SUM(SAL) ASC

--9. ������ �ѿ����� ����ϵ�, ������ 'MANAGER'��
-- ������� �����϶�. �׸��� �� �ѿ����� 5000���� 
-- ū ������ �ѿ��޸� ����϶�.
SELECT JOB, SUM(SAL)
FROM EMP
WHERE JOB != 'MANAGER'
GROUP BY JOB
HAVING SUM(SAL)>5000

--10. ������ �ִ������ ����ϵ�, ������ 'CLERK'�� 
-- ������� �����϶�. �׸��� �� �ִ������ 2000 �̻���
-- ������ �ִ������ �ִ� ������ ���� ������ �����Ͽ� 
-- ����϶�.
SELECT JOB, MAX(SAL) as 'maxsal'
FROM EMP
WHERE JOB!='CLERK'
GROUP BY JOB
HAVING MAX(SAL)>=2000
ORDER BY maxsal DESC


use KosaDB
--JOIN
--���� �ǽ� ���̺� �����
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
���� �Ѱ� �̻��� ���̺��� �����͸� �������� ���

����
inner join
cross join
outer join
self  join
nonequi join

ǥ����
�� ���� (oracle, mysql , mssql) ������ ����
ǥ�ع��� : ansi ���� ^^
*/

-- inner join

--SQL ����
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

--������̺��� ��� , �̸� , �μ���ȣ , �μ��̸��� ����ϼ���
select * from emp
select * from dept

select emp.empno , emp.ename , emp.deptno , dept.dname
from emp inner join dept
on emp.deptno = dept.deptno

--�ϼ��� ����
select e.empno, e.ename , e.deptno , d.dname
from emp e inner join dept d
on e.deptno = d.deptno

select e.empno, e.ename , e.deptno , d.dname
from emp e join dept d  --default inner 
on e.deptno = d.deptno

-------------------------------------------------------------
--cross join (������ ���� ����)
select * from m , s

--ansi
select *
from m cross join s

---------------------------------------------------------------
--outer join
--���ο� �������� �ʴ� �����Ͱ� ����
--���� �����͸� �������� ��� (null)

--���������� [inner join ����]�ϰ� �������踦 �ľ��ؼ� ���� �����͸� ������ ���� ���
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
--���� : reft  �� right  >> union 

----------------------------------------------------
--union ������
--1. ������� [�÷��� ��]�� [��ġ]�Ͽ��� �Ѵ�
--2. ������� [�÷��� �ڷ���(Ÿ��)] ��ġ

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
union  --�ߺ�����
select * from emp

select * from emp
union all
select * from emp

-----------------------------------------------------
--self join (�Ѱ��� ���̺� 2�� ó��)
--�ڽ��� Ư�� �÷��� �ڽ��� Ư�� �÷��� ����

--��� , �̸� ,�����ڻ�� , ������ �̸� ����ϼ���

select e.empno , e.ename , m.empno , m.ename
from emp e inner join emp m
on e.mgr = m.empno

--^^ ���� �߻� ����� 14�� 
--���� �����ʹ� 13��
--null join�� ����� �ƴϴ�
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
--1:1 ���εǴ� �÷��� ����� .... �־��  >> inner join

----------------------------------------------------------------
--���̺� 2 , 3, 4 �� ����
select m.m1 , m.m2 ,  s.s2 , x.X2
from m join s on m.m1 = s.s1
       join x on s.s1 = x.x1

/*
select m.m1 , m.m2 ,  s.s2 , x.X2
from m join s on m.m1 = s.s1
       join x on s.s1 = x.x1
	   join y on x.x1 = y.y1
*/
--����� ��� , �̸� , �޿� , �޿���� , �μ���ȣ , �μ��̸��� ����ϼ���
select *
from emp e join dept d on e.deptno = d.deptno
           join salgrade s on e.sal between s.losal and s.hisal

--�μ���ȣ�� 10���� ������� �μ���ȣ, �μ��̸�, �����ȣ, ����̸��� ����϶�.
select *
from emp e join dept d on e.deptno = d.deptno
where e.deptno = 10 

--�μ���ȣ�� 20�� ������ ������� �μ���ȣ, �μ��̸�, �����ȣ, ����̸��� ����ϵ�, �μ���ȣ�� ���� ������ �����϶�.
select *
from emp e join dept d on e.deptno = d.deptno
where e.deptno <= 20
order by d.deptno

-- 1. ������� �̸�, �μ���ȣ, �μ��̸��� ����϶�.
SELECT E.ENAME, E.DEPTNO, D.DNAME
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO

-- 2. DALLAS���� �ٹ��ϴ� ����� �̸�, ����, �μ���ȣ, �μ��̸���
-- ����϶�.
SELECT E.ENAME, E.JOB, D.DEPTNO, D.DNAME
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO 
WHERE  LOC='DALLAS'

-- 3. �̸��� 'A'�� ���� ������� �̸��� �μ��̸��� ����϶�.
SELECT E.ENAME, D.DNAME
FROM EMP E inner join DEPT D
on D.DEPTNO=E.DEPTNO 
WHERE  E.ENAME LIKE '%A%'

-- 4. ����̸��� �� ����� ���� �μ��� �μ���, �׸��� ������ 
--����ϴµ� ������ 3000�̻��� ����� ����϶�.
SELECT e.ENAME, d.DNAME, e.SAL , e.deptno
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO 
where e.SAL>=3000

-- 5. ������ 'SALESMAN'�� ������� ������ �� ����̸�, �׸���
-- �� ����� ���� �μ� �̸��� ����϶�.
SELECT E.JOB, E.ENAME, D.DNAME
FROM EMP E inner join DEPT D
on E.DEPTNO=D.DEPTNO 
where E.JOB='SALESMAN'

-- 6. Ŀ�̼��� å���� ������� �����ȣ, �̸�, ����, ����+Ŀ�̼�,
-- �޿������ ����ϵ�, ������ �÷����� '�����ȣ', '����̸�',
-- '����','�Ǳ޿�', '�޿����'���� �Ͽ� ����϶�.
SELECT E.EMPNO AS '�����ȣ', E.ENAME AS '����̸�', 
	E.SAL*12 AS '����', E.SAL*12+isnull(COMM,0) AS '�Ǳ޿�',
	S.GRADE AS '�޿����'
FROM EMP E inner join SALGRADE S on E.SAL BETWEEN S.LOSAL AND S.HISAL
where COMM IS NOT NULL

-- 7. �μ���ȣ�� 10���� ������� �μ���ȣ, �μ��̸�, ����̸�,
-- ����, �޿������ ����϶�.
SELECT E.DEPTNO, D.DNAME, E.ENAME, E.SAL, S.GRADE
FROM EMP E inner join DEPT D on E.DEPTNO=D.DEPTNO  
           inner join SALGRADE S on E.SAL BETWEEN S.LOSAL AND S.HISAL
WHERE E.DEPTNO=10
	

-- 8. �μ���ȣ�� 10��, 20���� ������� �μ���ȣ, �μ��̸�, 
-- ����̸�, ����, �޿������ ����϶�. �׸��� �� ��µ� 
-- ������� �μ���ȣ�� ���� ������, ������ ���� ������ 
-- �����϶�.
SELECT E.DEPTNO, D.DNAME, E.ENAME, E.SAL, S.GRADE
FROM EMP E inner join DEPT D on E.DEPTNO=D.DEPTNO 
           inner join SALGRADE S on E.SAL BETWEEN S.LOSAL AND S.HISAL
WHERE  E.DEPTNO<=20
ORDER BY E.DEPTNO ASC,  E.SAL DESC

------------------------------------------------------------------------------
--subquery 

-- jones �� �޴� �޿����� �� ���� �޿��� �޴� ����� �̸��� �޿��� ����ϼ���
select sal from emp where ename='JONES' --2975

select ename , sal 
from emp
where sal > 2975


select ename , sal 
from emp
where sal > (select sal from emp where ename='JONES')

/*
1. ��ȣ �ȿ� ..
2. �ܵ����� ���� ����
3. �����÷����� ����  (select sal , deptno ...(x)

�������
���������� �������� ���� �켱


����
single row subquery : ����� 1���� row  ( > < = >=
multi row subquery  : ����� ���� row   (in , not in  , any , all)
�����ϴ� ������ ����ϴ� �����ڰ� �޶��
*/


--������ salesman �� ������ ���� �޿��� �޴� ������� ��� , �̸� , �޿������� ����ϼ���
select sal from emp where job='SALESMAN'
--1600 1250 1250 1500
select empno , ename ,sal
from emp
where sal = 1600 or sal = 1250 or sal=1500


select empno , ename ,sal
from emp
where sal in (select sal from emp where job='SALESMAN')
--where sal = 1600 or sal = 1250 or sal=1500

--�μ���ȣ�� 10���� ������ ���� �޿��� �޴� ������� ����� ����ϼ���
select sal from emp where deptno=10

select *
from emp
where sal in (select sal from emp where deptno=10)

--���������� �ִ� ����� ����� �̸��� ����ϼ���
--�ڽ��� ����� mgr �ѹ� ������ ...
select mgr from emp

select *
from emp
where empno in (select mgr from emp)
--empno = 7902 or empno=7788

--����������  ���� ����� ����� �̸��� ����ϼ���
--mgr �÷��� ������ ����� ������ ... (������ �ƴϿ���)

select *
from emp
where empno not in (select isnull(mgr,0) from emp)
--empno != 7902 and empno != 7369 and .....null  >> null ���� �������� >> null

--20�� �μ��� ����߿��� �޿��� ���� ���� �޴� ������� �� ���� �޿��� �޴� ��� ��� ������ ����ϼ���

select max(sal) from emp where deptno=20

select *
from emp
where sal > (select max(sal) from emp where deptno=20)


select *
from emp
where sal > ALL(select sal from emp where deptno=20)

-- where sal > data and sal > data and sal > data and...



--20�� �μ��� ����� ���� ���� ������ �޴� ����麸�� �� ���� ������ �޴� ������� �̸��� ������ ����϶�.
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

--������ ��SALESMAN���� ����� ���� [�μ�]���� �ٹ��ϰ� ���� [����]�� �޴� ������� �̸�, ����, �μ���ȣ�� ����϶�.




select ename , sal , deptno
from emp
where deptno in (select deptno from emp where job='SALESMAN') 
      and sal in (select sal from emp where job='SALESMAN')
	  --and �÷� = ()

--�ڱ� �μ��� ��� ���޺��� �� ���� ������ �޴� ������� �̸�, ����, �μ���ȣ, �μ��� ��տ����� ���Ͻÿ�.
--�μ��� ��տ����� ��� �ִ� ���̺��� ����� ... �޸� ��� ���� ....  subquery .... from ... �������̺�
--1. if ... ��տ����� ��� �ִ� ���̺��� �����Ѵٸ�
/*
   �μ�  ��տ���
   10   23234
   20   12342
*/
--2.suquery �� from ���� ��밡��

select deptno , avg(sal) from emp group by deptno

--�ǹ� .... (in line view)
select *
from emp e inner join (select deptno , avg(sal) as avgsal from emp group by deptno) d
on e.deptno = d.deptno
where e.sal > d.avgsal

--TIP)
--���� (�Լ�) : ������ (JOIN) >> �ذ� �ȵǸ� >> subquery  >> in line view(�������̺�)
--1. 'SMITH'���� ������ ���� �޴� ������� �̸��� ������ ����϶�.
SELECT ENAME, SAL
FROM EMP
WHERE SAL>(SELECT SAL
		FROM EMP
		WHERE ENAME='SMITH')

--2. 10�� �μ��� ������ ���� ������ �޴� ������� �̸�, ����,
-- �μ���ȣ�� ����϶�.
SELECT ENAME, SAL, DEPTNO
FROM EMP
WHERE SAL IN(SELECT SAL
		FROM EMP
		WHERE DEPTNO=10)

--3. 'BLAKE'�� ���� �μ��� �ִ� ������� �̸��� ������� �̴µ�
-- 'BLAKE'�� ���� ����϶�.
SELECT ENAME, HIREDATE
FROM EMP
WHERE DEPTNO=(SELECT DEPTNO
		FROM EMP
		WHERE ENAME='BLAKE')
AND ENAME!='BLAKE'

--4. ��ձ޿����� ���� �޿��� �޴� ������� �����ȣ, �̸�, ������
-- ����ϵ�, ������ ���� ��� ������ ����϶�.
SELECT EMPNO, ENAME, SAL
FROM EMP
WHERE SAL>(SELECT AVG(SAL)
		FROM EMP)
ORDER BY SAL DESC

--5. �̸��� 'T'�� �����ϰ� �ִ� ������ ���� �μ����� �ٹ��ϰ�
-- �ִ� ����� �����ȣ�� �̸��� ����϶�.
SELECT EMPNO, ENAME
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
		FROM EMP
		WHERE ENAME LIKE '%T%')

--6. 30�� �μ��� �ִ� ����� �߿��� ���� ���� ������ �޴� �������
-- ���� ������ �޴� ������� �̸�, �μ���ȣ, ������ ����϶�.
--(��, ALL(����  : and) �Ǵ� ANY(���� : or) �����ڸ� ����� ��)
SELECT ENAME, DEPTNO, SAL
FROM EMP
WHERE SAL >ALL(SELECT SAL   --max(sal)
		FROM EMP
		WHERE DEPTNO=30)

--7. 'DALLAS'���� �ٹ��ϰ� �ִ� ����� ���� �μ����� ���ϴ� �����
-- �̸�, �μ���ȣ, ������ ����϶�.
SELECT ENAME, DEPTNO, JOB
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
			FROM DEPT
			WHERE LOC='DALLAS')

--8. SALES �μ����� ���ϴ� ������� �μ���ȣ, �̸�, ������ ����϶�.
SELECT DEPTNO, ENAME, JOB
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
			FROM DEPT
			WHERE DNAME='SALES')

--9. 'KING'���� �����ϴ� ��� ����� �̸��� �޿��� ����϶�.
SELECT ENAME, SAL
FROM EMP
WHERE MGR=(SELECT EMPNO
		FROM EMP
		WHERE ENAME='KING')

--10. �ڽ��� �޿��� ��� �޿����� ����, �̸��� 'S'�� ����
-- ����� ������ �μ����� �ٹ��ϴ� ��� ����� �����ȣ, �̸�,
-- �޿��� ����϶�.
SELECT EMPNO, ENAME, SAL
FROM EMP
WHERE SAL > (SELECT AVG(SAL)
		FROM EMP)
AND DEPTNO IN(SELECT DEPTNO
		FROM EMP
		WHERE ENAME LIKE '%S%')

--11. Ŀ�̼��� �޴� ����� �μ���ȣ, ������ ���� �����
-- �̸�, ����, �μ���ȣ�� ����϶�.
SELECT ENAME, SAL, DEPTNO
FROM EMP
WHERE DEPTNO IN(SELECT DEPTNO
		FROM EMP
		WHERE COMM IS NOT NULL)
AND SAL IN(SELECT SAL
		FROM EMP
		WHERE COMM IS NOT NULL)

--12. 30�� �μ� ������ ���ް� Ŀ�̼��� ���� ����
-- ������� �̸�, ����, Ŀ�̼��� ����϶�.
SELECT ENAME, SAL, COMM
FROM EMP
WHERE SAL NOT IN(SELECT SAL
		FROM EMP
		WHERE DEPTNO=30)
AND COMM NOT IN(SELECT ISNULL(COMM, 0)
		FROM EMP
		WHERE DEPTNO=30)

---------------------------------------------------------------------------------
--DML (insert , update , delete) ������ �ϱ�
--������ ���۾�

--insert ... �ǹݿ�
--insert , update , delete ..begin tran ~~~~~ commit 

create table Test(
  userid int
)

insert into Test(userid) values(100) --�ǹݿ� 

select * from Test

begin tran
  insert into Test(userid) values(200)
rollback
--�Ϸ� ,��� (commit , rollback)
select * from Test

begin tran
  delete from Test
commit  

/*
MSSQL DML �۾��� autocommit �մϴ�
begin tran
  DML �ۼ��Ͻø�
commit , rollback ������ ����

Oracle DML �۾��� ���ؼ� default begin tran

begin tran ����
insert ..... 
�ݵ�� commit , rollback ���� ...


 Ʈ�����
 transaction
 �ϳ��� ������ �۾� ���� (���� or ����)
 �������
 A���� B���� ��ü
 ���⼭ ..
 A = A - 1000

 B = B + 1000
 ������� �ϳ��� ���� ...
*/


--insert 
--1. ��ü �÷��� ������ ����

insert into emp(empno ,ename, job, mgr , hiredate, sal , comm, deptno)
values(9999,'ȫ�浿','IT',7902,getdate(),3000,100,10)

select * from emp

insert into emp
values(9991,'ȫ�浿','IT',7902,getdate(),3000,100,10)

select * from emp

--Ư�� �÷��� ������ ���� (�ݵ�� �÷��� ���)
insert into emp
values(5555,'�ƹ���',800) --(x)


insert into emp(empno, ename,sal)
values(9992,'�ƹ���',800)

select * from emp order by empno desc


insert into emp(empno , ename, hiredate , deptno)
values(9998 , '����' , '2022-01-01',10)

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

-- �̸��� ��SCOTT���� ����� ������ 0���� �����϶�.

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
--DELETE ������ ����

--�����ȣ 7902 ������ ����
begin tran
 delete from emp where empno=7902
rollback
select * from emp where empno=7902

begin tran
	delete from emp
rollback
	select *from emp

---------------------------------------
--�ΰ����� �ɼ� ...
/*
	select ~ into  (���̺� ���� �� ������ insert����)

	insert ~ select(�뷮 ������ ����)
*/

select *
into emp01
from emp
--emp01���̺� ����� ������ insert

select * from emp01

select empno , ename ,job ,sal
 into emp02
from emp
where 'A' = 'B'


select * from emp02

---------------------------------------------

insert into emp (empno,ename)
values(1111,'AAA')

--values ��� select �����

insert into emp02(empno , ename ,job ,sal)
select empno , ename,job , sal from emp where deptno=10

select * from emp02

--------------------------------------------------------
--�ǽ�

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


-- ��� �ǽ������� EMP ���̺��� ������ ������ ���� BEGIN TRAN...
-- ROLLBACK TRAN ������ ����� ��
use kosaDB
select * 
	into emptest
from emp

select *from emptest

--emptest �� �������� Ǫ����
-- ��� �ǽ������� EMP ���̺��� ������ ������ ���� BEGIN TRAN...
-- ROLLBACK TRAN ������ ����� ��

-- 1. EMP ���̺��� �����ȣ�� 7499���� ����� ������ 5000�޷��� �ٲ��.
BEGIN TRAN 
	UPDATE EMP
	SET SAL=5000
	WHERE EMPNO=7499

	SELECT * FROM EMP	--> ������ ���� Ȯ��

ROLLBACK TRAN

-- 2. EMP���̺��� �μ���ȣ�� 20���� ������� ������ 4000�޷��� �ٲ��.
BEGIN TRAN

	UPDATE EMP
	SET SAL=4000
	WHERE DEPTNO=20

	SELECT * FROM EMP	--> ������ ���� Ȯ��

ROLLBACK TRAN

-- 3. DEPT ���̺� �Ʒ��� �������� �����͸� �Է��϶�.
-- �μ���ȣ: 50, �μ���ġ: BOSTON,  �μ���: RESERCH
BEGIN TRAN

	INSERT INTO DEPT(DEPTNO, LOC, DNAME)
	VALUES(50,'BOSTON','RESERCH')

	SELECT * FROM DEPT	--> ������ �Է� Ȯ��

ROLLBACK TRAN

-- 4. �����ȣ�� 7698���� ����� �μ���ȣ�� 7499�� ����� 
--�μ���ȣ�� �ٲ��.
BEGIN TRAN

	UPDATE EMP
	SET DEPTNO=(SELECT DEPTNO
			FROM EMP
			WHERE EMPNO=7499)
	WHERE EMPNO=7698

	SELECT * FROM EMP	--> ������ ���� Ȯ��

ROLLBACK TRAN

-- 5. EMP ���̺� �Ʒ��� ���� �����͸� �����϶�.
-- �����ȣ: 9900, ����̸�: JACKSON, ����: SALESMAN, �μ���ȣ: 10
BEGIN TRAN

	INSERT INTO EMP(EMPNO, ENAME, JOB, DEPTNO)
	VALUES(9900, 'JACKSON', 'SALESMAN', 10)

	SELECT * FROM EMP	--> ������ �Է� Ȯ��

ROLLBACK TRAN

-- 6. INSERT...SELECT ���� �̿��Ͽ� ������ 'SALESMAN'��
-- ����� �����ȣ, �̸�, ������ EMP ���̺� �Է��϶�.
BEGIN TRAN

	INSERT INTO EMP(EMPNO, ENAME, JOB)
		SELECT EMPNO, ENAME, JOB
		FROM EMP
		WHERE JOB='SALESMAN'

	SELECT * FROM EMP	--> ������ �Է� Ȯ��

ROLLBACK TRAN

-- 7. �����ȣ�� 7369���� ����� ���� ������ ���� �������
-- ������ 7698�� ����� �������� �����϶�.
BEGIN TRAN

	UPDATE EMP
	SET SAL=(SELECT SAL
			FROM EMP
			WHERE EMPNO=7698)
	WHERE JOB=(SELECT JOB
			FROM EMP
			WHERE EMPNO=7369)

SELECT * FROM EMP	--> ������ �Է� Ȯ��

ROLLBACK TRAN


-- 8. SCOTT�� ���� ������ ���� ����� ��� �����϶�.
BEGIN TRAN

	DELETE FROM EMP
	WHERE JOB=(SELECT JOB
				FROM EMP
				WHERE ENAME='SCOTT')
	SELECT * FROM EMP	--> ������ ���� Ȯ��

ROLLBACK TRAN

-- 9. 'SCOTT'�� ������ 'SMITH'�� ���ް� ���� �����϶�.
BEGIN TRAN

	UPDATE EMP
	SET SAL=(SELECT SAL
			FROM EMP
			WHERE ENAME='SMITH')
	WHERE ENAME='SCOTT'

	SELECT * FROM EMP	--> ������ ���� Ȯ��
ROLLBACK TRAN

-- 10. 'ALLEN'�� ������ 'SCOTT'�� ������ ���� �����϶�.
BEGIN TRAN

	UPDATE EMP
	SET JOB=(SELECT JOB
			FROM EMP
			WHERE ENAME='SCOTT')
	WHERE ENAME='ALLEN'
	SELECT * FROM EMP
ROLLBACK TRAN

-- 11. �����ȣ�� 7499���� ����� ���� ������ ���� �������
-- �Ի����� ���ó�¥�� �����϶�.
BEGIN TRAN

	UPDATE EMP
	SET HIREDATE=GETDATE()
	WHERE JOB=(SELECT JOB
			FROM EMP
			WHERE EMPNO=7499)

	SELECT * FROM EMP	--> ������ ���� Ȯ��

ROLLBACK TRAN

-- 12. SCOTT�� ���� ������ ���� ������� ������ 0���� �����϶�.
BEGIN TRAN

	UPDATE EMP
	SET SAL=0
	WHERE JOB=(SELECT JOB
			FROM EMP
			WHERE ENAME='SCOTT')

	SELECT * FROM EMP	--> ������ ���� Ȯ��

ROLLBACK TRAN

----------------------------------------------------
--DDL : ���Ǿ� >> create , alter , drop
--1. DB ��������
--2. �� ����Ҿȿ� ... Table ���� ....

use KosaDB

sp_helpdb kosadb  --DB�⺻���� ��ȸ�ϱ�

--DDL table ����
create table emp10   -- class Emp10{ public int Empno{get;set;}   }
(
	empno int,
	ename nvarchar(20),
	hirdate datetime
)

/*
char(10)    >> ����,Ư��,���� 10�� >> �ѱ�5��  >> �������̹��ڿ�
varchar(10) >> ����,Ư��,���� 10�� >> �ѱ�5��  >> �������̹��ڿ�

������: '��' �Ǵ� '��'
create table T ( gender char(2))   (0)  >> ���������� ����    
create table T ( gender varchar(2)) 

������ ����� �̸� : ...�̼��� , ����ѹ�....
create table T (name char(50))  >> 6byte >> 50byte
create table T (name varchar(50)) >> 50byte >> 6byte

�������ѱ� ..ȥ��
unicode
create table T ( gender nchar(4))       ���� 4���� (���� , �ѱ� ������� 4����)
create table T ( gender nvarchar(4)) 

*/

--���̺� ����

sp_help emp10  --�ϱ�

insert into emp10(empno,ename,hirdate)
values(100,'ȫ�浿',getdate())

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
values(1,'�̼���','�λ��','1960-12-12')

select * from member2
--hobby >> null 


insert into member2(id,name,address,birth,hobby)
values(2,'������','�λ��','1960-12-12','��Ÿ��')

select * from member2

insert into member2(id)
values(3)

select * from member2

--1. �������̺� �÷� �߰��ϱ�
alter table member2
add gender char(1)

sp_help member2

--2. �������̺� �����÷��� Ÿ�Ժ����ϱ�
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
	empno int not null, --�ʼ��Է�
	ename varchar(20) -- default null --�ΰ��Է�
)

insert into emp03(empno) values(7788)

select * from emp03

insert into emp03(ename) values('�ƹ���') --�ȵǿ�  empno not null (null ������� �ʾƿ�)

insert into emp03(empno,ename) values(7902,'������')

select * from emp03

create table emp04
(
	empno int default 1000,
	ename varchar(20)
)
sp_help emp04  --default Ȯ��

insert into emp04(empno,ename) values(1111,'�达')

select * from emp04

insert into emp04(ename) values('�ھ�')
insert into emp04(ename) values('�̾�')

select * from emp04

sp_helpconstraint emp04

--DF__emp04__empno__3A81B327 �����̸�  (�̸��� ������ ���߿� ����,���� ���)

create table emp05
(
	empno int constraint df_emp04_empno default 1000,
	ename varchar(20)
)

--df_emp04_empno ������ ǥ�� (��κ� ���� ������ ǥ��)

sp_helpconstraint emp05

create table user02
(
	u_id int not null,
	u_name nvarchar(20),
	u_job  varchar(50) constraint df_user02_u_job default 'IT'
)

sp_helpconstraint user02

insert into user02(u_id, u_name, u_job)
values(10,'ȫ�浿','����')

select * from user02

insert into user02(u_id, u_name)
values(20,'�̼���')

select * from user02

--ȸ�����̺� default ...���Գ�¥ (getdate())

-------------------------------------------------------------------------
--���� (constraint)
/*
Data Integrity�� ���� ��� (���Ἲ)

������ ���
1. ���̺� ������ �����ϴ� ���: CREATE TABLE�� ���
2. ������� ���̺� ���� �ϴ� ���: ALTER TABLE�� ��� **^^


������ ����

1. NOT NULL 

2. DEFAULT

3. PRIMARY KEY (not null  + unique) >> �ֹι�ȣ, ����, ����....   �Ѱ��� row ��ȯ ���� �� 
                                    >> where num =1 , where jumin=123456-1235467
									>> �˻� .... �ӵ� ��� ... index ... 
									>> ���̺� 1��(����) > 1�� , 2��() , 3��() > ����Ű

4. UNIQUE  (�ߺ��� ��� ���ؿ�)     >> not null �������� �ʾƿ�
                                    >> �˻�  index
									>> �÷� �� ��ŭ

5. CHECK (���Ǵ¿� ���ü� �־� , 1~10������ �ü� �־� )  where gender in ('��','��')


6. FOREIGN KEY                      >> Today point (�ܷ�Ű , ����Ű) ��������
                                    >> ���̺�� ���̺��� [���� ����] RDBMS
									>> ����) �θ� �ڽ� , master  detail 
									>> EMP .... DEPT
									>> Emp deptno �÷��� Dept deptno�÷��� ���� �մϴ� (FK)
									>> Dept deptno �÷��� Emp deptno�÷��� ������ ���մϴ� (PK)

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

insert into emp06(empno,ename) values(100,'������')

insert into emp06(empno,ename) values(100,'�̼���')
--PRIMARY KEY ���� ���� 'pk_emp06_empno'��(��) �����߽��ϴ�. ��ü 'dbo.emp06'�� �ߺ� Ű�� ������ �� �����ϴ�. 
--�ߺ� Ű ���� (100)�Դϴ�.

insert into emp06(ename) values('�̼���')
--���̺� 'KosaDB.dbo.emp06', �� 'empno'�� NULL ���� ������ �� �����ϴ�. 
--������ NULL�� ����� �� �����ϴ�. INSERT��(��) �����߽��ϴ�.

--���̺�� 1�� (���)
--����Ű

create table pktable
(
	a int , 
	b int ,
	c int

	constraint pk_pktable_a_b primary key(a,b)
)
--����Ű ������ 
--where b = 10  (���� ..index(x))
--where a = 10 and b = 20  (good)
--where a = 10 .....

sp_helpconstraint pktable

/*
>>�̷����̺�

�λ����̺�
2000 1   IT
2000 2   SALAES


�з����̺�
2000  1  ��õ��
2000  2  ��õ��


��� �޿���
2000 1
2001 2
2000 2

*/


create table emp07
(
   empno int constraint uk_emp07_empno unique, --�ߺ������� ������� �ʾƿ�  --UNIQUE (non-clustered)
   ename varchar(20)
)

sp_helpconstraint emp07

insert into emp07(empno, ename) values(1000,'�达')
select* from emp07

insert into emp07(ename) values('�达')
insert into emp07(ename) values('�ھ�')
--UNIQUE KEY ���� ���� 'uk_emp07_empno'��(��) �����߽��ϴ�. ��ü 'dbo.emp07'�� �ߺ� Ű�� ������ �� �����ϴ�. 
--�ߺ� Ű ���� (<NULL>)�Դϴ�.

create table emp08
(
   empno int not null constraint uk_emp09_empno unique, --�ߺ������� ������� �ʾƿ�  --UNIQUE (non-clustered)
   ename varchar(20)
)

-- �׷���  empno int not null constraint uk_emp09_empno unique >> primary key ���� �� �ƴϾ� 

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
  gender char(2) constraint ck_emp10_emp10_gender check(gender in ('��','��'))
)
--([gender]='��' OR [gender]='��')
sp_helpconstraint emp11

insert into emp11(empno,ename,gender) values(1000,'��','��')
--INSERT ���� CHECK ���� ���� "ck_emp10_emp10_gender"��(��) �浹�߽��ϴ�. 
--�����ͺ��̽� "KosaDB", ���̺� "dbo.emp11", column 'gender'���� �浹�� �߻��߽��ϴ�.

insert into emp11(empno,ename,gender) values(1000,'��','��')

--��������--------------------------------------
select * from emp

select * from dept

--MSSQL ���� not null ���� ���� �÷��� ���ؼ� ..PK ���� ���ؿ�
alter table dept
alter column deptno int not null


alter table dept
add constraint pk_dept_deptno primary key(deptno)

alter table emp
add constraint fk_emp_deptno foreign key(deptno) references dept(deptno)

--�����Ǵ� ���̺� 'dept'�� �ܷ� Ű 'fk_emp_deptno'�� ���� �� ��ϰ� ��ġ�ϴ� �⺻ Ű �Ǵ� �ĺ� Ű�� �����ϴ�.
--�ݵ�� �����ϴ� ���̺� PK ����Ǿ�� �Ѵ�


--�ɼ�
--identity(������)
--ä�� (��ȣǥ) 
--sequence (��ü ��ȣǥ) : oracle ,mssql

create table board(
  boardid int identity(1,1),
  title varchar(20)
)

insert into board(title) values('�氡')

select * from board;

create table emp20
(
	a int ,
	b int ,
	c as a+b --���� ��
)

insert into emp20(a,b) values(100,300)
select * from emp20

-------------------------------------------------------------------
--VIEW (�������̺�)
--Ȥ�ڴ� : SQL ���� ���

--View  ��ü (create ... drop  ��������)

create view tbl_emp
as
   select empno , ename, job, deptno from emp

--���� : ���� ���̺� >> ���̺�ó�� >> �並 ���ؼ� 

select * from tbl_emp --view������ SQL���� ����
select * from tbl_emp where deptno=10 -- view�� ���ؼ� ���� �ִ� ������ ...������ �� �� �ִ�

sp_help tbl_emp
--tbl_emp	dbo	 view	2022-03-24 14:47:57.450
sp_helptext tbl_emp

--���� (���� �ܼ�ȭ >> �������� ���̺��� ���� ��� >> view �������̺� ���� >> JOIN)
create view v_emp  --�μ���ȣ , �μ��̸� ,��� ..... �Ź� join
as
	select empno , ename ,e.deptno, dname
	from emp e inner join dept d
	on e.deptno = d.deptno

select * from  v_emp

--���) ������ ��� ������ �� �˰� �ִٸ� view ��¥

--������ salesman�� ������� �̸� , ���� , ������ �����ִ� view  �ۼ��ϼ���

	select ename, sal, job
	from emp 
	where job='SALESMAN'

	create view v_emp2
	as
	  select ename, sal, job
	  from emp 
	  where job='SALESMAN'


  select * from v_emp2

  --�μ���ȣ�� 30���� ����� �̸�, �޿�, �μ���ȣ �� �����ִ� View�ۼ��ϼ���

  create view v_emp3
  as
    select ename, sal , deptno 
	from emp
	where deptno=30

	select * from v_emp3

--view�� ���̺�� dml �۾�
--view [���ؼ�] �������̺��� view�� ���� �ִ� �͸� insert , update , delete�۾� ���� �ϴ�
--�׷��� ���� ������

select * from v_emp3

begin tran
	update v_emp3
	set sal = 0
rollback

select * from emp
select * from v_emp3

--�μ��� ��� ������ ��� �ִ�view �� �ۼ��϶�
--subquery   from (select deptno , avg(sal) as svgsal from emp....) e)

create view empavg
as
  select deptno , avg(sal)as avgsal from emp group by deptno

 select *
 from emp e join empavg s on e.deptno = s.deptno and e.sal > s.avgsal

 --1. ���� (������ ����(����) ..view ����) ���ϰ�
 --2. ���� ���̺� (���ϴ� �����͸� ����) join ���� �� ó��

 -- ������̺��� �̸��� ���޸� ��� VIEW�� �ۼ��ϵ�, ������ ���� ������ ����϶�.
 -- view ������ order by ������� ������
 create view view001
 as
   select top 20 ename , sal from emp order by sal desc

select * from view001

--1. 30�� �μ� ������� ����, �̸�, ������ ��� VIEW�� ������.
CREATE VIEW VIEW100
AS
	SELECT JOB, ENAME, SAL
	FROM EMP
	WHERE DEPTNO=30
SELECT * FROM VIEW100

--2. 30�� �μ� �������  ����, �̸�, ������ ��� VIEW�� ����µ�,
-- ������ �÷����� ����, ����̸�, �������� ALIAS�� �ְ� ������
-- 300���� ���� ����鸸 �����ϵ��� �϶�.
CREATE VIEW VIEW101
AS
	SELECT JOB AS '����', ENAME AS '����̸�', SAL AS '����'
	FROM EMP
	WHERE DEPTNO=30 AND SAL > 300
SELECT * FROM VIEW101

--4. �μ��� ��տ����� ��� VIEW�� �����, ��տ����� 2000 �̻���
-- �μ��� ����ϵ��� �϶�.
CREATE VIEW VIEW103
AS
	SELECT DEPTNO, AVG(SAL) AS '��տ���'
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


--DATETIME ������ Ÿ���� ������ @ymd ������ �����ϰ�,
--�� ������ GETDATE()�Լ��� ����Ͽ� ���� ��¥�ð��� ������ ���� ȭ�鿡 ����϶�.

DECLARE @ymd datetime
SET @ymd=GETDATE()
SELECT @ymd

--INT ������ Ÿ���� ������ @sal ������ �����ϰ�, 
--�� ������ 5000�̶�� �ʱⰪ�� �㵵�� �����϶�. 
--�׸��� EMP ���̺��� ������ @sal�� ����� �̸��� ������ ����϶�.
DECLARE @sal int
SET @sal=5000
	SELECT ENAME, SAL
	FROM EMP
	WHERE SAL=@sal

--EMP ���̺�κ��� ��տ����� ��� ������ �����ϰ�, 
--�� ������ �̿��� ��տ��޺��� �� ���� ������ �޴� ����� ��� ������ ����ϴ� �������� �ۼ��϶�.

DECLARE @avg int
SET @avg=(SELECT AVG(SAL) FROM EMP)
	SELECT *
	FROM EMP
	WHERE SAL>@avg

--Q1. ���� @i�� ������ ���� �����ϰ� @i�� ���� 100���� ���� ���� 
--100�̻��� ��츦 ������ ��� �޽����� �ٸ��� �Ѹ��� 
--IF��ELSE���� �ۼ��϶�.

declare @i int
set @i = 250
if @i < 300
	select convert(varchar(10),@i) + ' �� ���� �۽��ϴ�' 
else
    select convert(varchar(10),@i) + ' �� ���� Ů�ϴ�' 

--begin ~ end  ��
declare @sal int
set @sal = 2000
if @sal >= 3000
	begin
		print '������ 3000�޷� �̻��� �����'
		select *
		from emp
		where sal >= 3000
	end
else
	begin
		print '������ 3000�޷� �̸��� �����'
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
		     '�氡�氡'
         end
	   ) as '�ϳ��� �÷�' , 111 as '������1',222 as '������2',333 as '������3' , null as '������4'
from emp



select empno , ename , job , deptno , 
       ( 
	     case 
			when deptno = 10 then 'AA'
	        when deptno between 20 and 30 then 'BB'
			when deptno in (40,50) then 'CC'
         else  
		     '�氡�氡'
         end
	   ) as '�ϳ��� �÷�' , 111 as '������1',222 as '������2',333 as '������3' , null as '������4'
from emp


--while  1~10������ ��
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
--���ν���
--����
--���� , ���� , ���� 

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

--���ν��� �̸�
--�ý��� ...���ν���
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

--* input �Ű����� ��� ����
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
--	exec myproc4  --���ν��� �Ǵ� �Լ� 'myproc4'�� �Ű� ���� '@i'��(��) �ʿ������� �������� �ʾҽ��ϴ�.

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
 Pubs DB�� title��� ���̺��� å �̸��� �� å�� ������ �������� MYPROC6��� ���ν����� ������. 
 �׸��� å �̸��� å�� ������ ����ڷκ��� �Է¹޵��� �� ���̸�, 
 ���� �Է����� �ʾ��� ��� default������ ���� ��%���� NULL�� ��µǵ��� �����Ͽ���.
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
exec myproc6 @price =19.99  --Ư�� �Ķ���� .. ������ @price
exec myproc6 '%talk%',19.99
exec myproc6 @price=19.99 ,@title='%talk%'  --Straight Talk About Computers	19.99

--�ý��� ���ν���
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


exec myproc7 10 , 20  --���ν��� �Ǵ� �Լ� 'myproc7'�� �Ű� ���� '@c'��(��) �ʿ������� �������� �ʾҽ��ϴ�.

declare @out int
exec myproc7 10,20,@out output
select @out
--ó�� �Է��� ���ڿ� 30�� ���� ��, ���� ���� �� ��° ���ڸ� ���� ���� ����ϴ� ���ν����� �ۼ��϶�.


CREATE PROC MYPROC8
@a int, @b int, @c int output
AS
SET @c=(@a+30)*@b

declare @out int
exec myproc8 10,20,@out output
select @out as '�����'

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

--output ���� return  ��뵵 ����
use KosaDB;
create proc myproc10
as
    declare @count int
	set @count = (select count(*) from emp)
	return @count

declare @return int
exec @return = myproc10
select @return

--return �Ǵ� ���� ������ ���� ���� ����
--������ ���� ����
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



