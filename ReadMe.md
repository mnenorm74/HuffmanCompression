После запуска проглама предлагает два варианта: ахивация и дезархивация.  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/1.png)  
Архивация:  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/2.png)  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/3.png)  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/6.png)  

Дезархивация:  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/4.png)  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/5.png)  
![](https://github.com/mnenorm74/HuffmanCompression/blob/master/HuffmanCompression/Pictures/7.png)  
  
Процесс сжатия:   
Файл считывается полностью, подсчитывается сколько раз встречается каждый  символ.    
Таблица соответствия символа чуслу его вхождений сортируется по количеству вхождений.  
Два элемента с минимальным числом вхождений образуют новый узел, частота вхождений для которого равна сумме частот вхождения элементов.  
Этот этап продолжается до тех пор, пока не будет получен один узел.  
Проходя по дереву, составляются кодирующие коды для символов. Прослеживаются все повороты ветвей, поворот влево добавляет 0 в запись числа, вправо 1.  
Символы заменяются на полученные битовые коды.  
Неприятность в том, что для восстановления первоначального файла нужно иметь декодирующие коды.  

