using List_HW;

ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 3, 4 });
ArrayList listt = new ArrayList(new int[] { 9, 9, 9 });

list.Write();


list.AddListByIndex(listt, 3);
list.Write();