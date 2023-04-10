# Итоговая контрольная работа по основному блоку # 
<br/>

## **Задача:** ##  
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.  
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  
<br/> <br/>

## **Требования по корректному выполнению задания** ##
<br/>
1. Создать репозиторий на GitHub <br/>
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод) <br/>
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md) <br/>
4. Написать программу, решающую поставленную задачу <br/>
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах) <br/> <br/> <br/>

# Описание решения задачи # 
<br/>

### **Шаг 1:** ###
Запрашиваем у пользователя количество строк, которые он хочет ввести, для того, чтобы узнать какого размера инициализировать массив. Затем записываем введеное значение в переменную userArraySize.
<br/>

### **Шаг 2:** ###
Напишем функцию, которая будет инициализировать массив строк размера введенного пользователем. Она будет иметь тип string[] и на выходе будет отдавать массив строк, а принимать в себя будет число строк, введеное пользователем. Назовем эту функцию - InitUserArray.
<br/>

### **Шаг 3:** ###
Напишем функцию, которая будет заполнять массив строк элементами, введенными пользователем. Назовем ее - FillArray. Функция имеет тип void, так как просто модифицирует уже существующий массив и принимает в себя ранее инициализированный пустой массив строк нужного пользователю размера.
В теле функции инициализируем переменную j со значением 0. Она будет отвечать за текущий индекс элемента. Далее пишем цикл for в нем переменная i будет означать номер строки, который будет выводится пользователю. В цикле запрашиваем у пользователя вводить строки пока i не будет равен значению перменной userArraySize. После того как пользователь введет строку, она запишется в элемент массива под индексом j. После этого увеличиваем значения i и j на 1.
<br/>

### **Шаг 4:** ###
Напишем функцию, которая будет выводить массив на экран терминала. Назовем ее - PrintArray Эта функция имеет тип void и принимает в себя массив строк. В цикле пробегаем по каждому элементу зашедшего массива и выводим его на экран. В методе есть дополнительные проверки для того, чтобы выводить массив с нужным форматированием.
<br/>

### **Шаг 5:** ###
Напишем функцию, которая будет возвращать размер массива, нужный для заполнения результирующего массива валидными элементами. Назовем ее - GetResultArraySize. Она будет иметь тип int и возвращать число, которое будет означать количество элементов из которых должен будет состоять итоговый массив. Принимать в себя она будет массив строк. В теле функции инициализируем переменную resultArraySize со значением 0, которая будет счетчиком количества элементов в итоговом массиве. Далее в цикле пробегаем по всем элементам и проводим проверку каждого элемента на соответствие требованиям задачи. Если длинна текущего элемента соответствует условию, то увеличиваем текущее значение переменной resultArraySize на 1.
<br/>

### **Шаг 6:** ###
Напишем функцию, которая будет заполнять итоговый массив валидными элементами. Она будет иметь тип void и принимать в себя 2 массива строк. 1 массив введеный пользователем и пустой итоговый массив, который надо заполнить валидными элементами из пользовательского массива. В теле функции инициализируем переменную resultArrElem со значением 0, которая будет индексом текущего элемента итогового массива. В цикле будем пробегать каждый элемент пользовательского массива и проводить проверку на соответствие условиям задачи. Если длинна текущего элемента пользовательского массива соответствует условию, то записываем его в итоговый массив на текущую позицию resultArrElem, затем увеличиваем значение переменной resultArrElem на 1.
<br/>

### **Шаг 7:** ###
В последнем шаге воспользуемся ранее написанными функциями для решения задачи. <br/>

- Инициализируем переменную userArray и положим в нее результат работы функции InitUserArray, в которую передадим аргументом переменную userArraySize. <br/>

- Воспользуемся функцией FillArray и передадим в нее созданный пользователем массив строк userArray. <br/>

- Воспользуемся функцией PrintArray, чтобы вывести на экран массив введенный пользователем. <br/>

- Инициализируем переменную resArraySize и положим в нее результат работы функции GetResultArraySize, в которую мы передадим аргумент пользовательский масссив. <br/>

- Инициализируем переменную resArray и положим в нее результат работы функции InitUserArray, в которую аргументом передадим переменную resArraySize. <br/>

- Воспользуемся функцией FillResultArray, чтобы заполнить результирующий массив. Аргументами передадим переменные userArray и resArray. <br/>

- Воспользуемся функцией PrintArray чтобы распечатать результирующий массив. <br/>

### В итоге на экране мы увидим массив введеный пользователем и под ним результирующий массив с валидными элементами. Задача решена. Всем спасибо, все свободны :-)