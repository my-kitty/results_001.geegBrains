
// ********** Ввод первоночального масива с клавиатуры*************
string[] array_string = new string[0];
Console.WriteLine("\n Програма решающяя простую задачу:");
Console.Write("\nПосле каждого введённого значения масива нажмите Enter \n");
Console.Write("Чтобы прикратить вводить значения ммасива введите команду <end> \n \n");
add_loop_array(ref array_string); // add_loop_array функция наполняет массив новыми значениями введёными с клавииатуры, условие выхода из ввода ввод слова <end>

Console.WriteLine($"\nВведёнй массив: [{string.Join(",", array_string)}]");



// ****** Формирование нового масива, длина которого <= 3 *******
string[] array_sort = new string[0];

for (int i = 0; i < array_string.Length; i++) { // array_string масив введённый с клавиатуры
	if(array_string[i].Length <= 3){
		array_add(ref array_sort, array_string[i]); // array_sort генирация нового масива, array_add() функция добовляет в каец масива новое значение
	}
}

Console.WriteLine($"Итогоый массив: [{string.Join(",", array_sort)}]");






// Функция которая заполняет массив
void add_loop_array(ref string[] array){
	while(true){
		Console.Write($"Введите эдемент [{array.Length}] масива: ");
		string my_string = Console.ReadLine()!;
		if(my_string == "end"){ break; }
		array_add(ref array, my_string); // array_add() функция добовляет в каец масива новое значение
	}
}

// функция которая добовляет в канец масива значение
void array_add(ref string[] array, string add_alement_end = "") {
	string[] array_2 = array;
	array = new string[array.Length + 1];

	for (int i = 0; i < array.Length - 1; i++) {
		array[i] = array_2[i];
	}
	array[array.Length - 1] = add_alement_end;
}

