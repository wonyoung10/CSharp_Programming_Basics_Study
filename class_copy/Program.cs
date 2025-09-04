// See https://aka.ms/new-console-template for more information
using class_copy;

Console.WriteLine("Hello, World!");




cItem item1 = new cItem();
item1.NAME = "정원영";
item1.PHONE = "010-3701-0418";

cItem item2 = new cItem();
item2.NAME = "정아름";
item2.PHONE = "010-2222-2222";

cItem item3 = new cItem();
item3.NAME = "정하윤";
item3.PHONE = "010-3333-3333";

cGroup Group1 = new cGroup();
Group1.FAMLIY = "산본";
Group1.LIST.Add(item1);
Group1.LIST.Add(item2);
Group1.LIST.Add(item3);


cGroup Group포인터복사 = Group1;


cGroup Group2 = new cGroup();

Group2 = cClass.Clone<cGroup>(Group1);

Group1 = Group2;




int k = 0;
