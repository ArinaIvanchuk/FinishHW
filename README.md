# Итоговая контрольная работа для выбора специализации.
 Написать программу, которая из имеющегося массива строк формирует новый массив 
 из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
 ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
 рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 Примеры:
 [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
 [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
 [“Russia”, “Denmark”, “Kazan”] → []
# Описание алгоритма создания программы:
# 1. Создание массива:
создаем строковый массив из 4 элементов.
# 2. Создание второго массива:
создаем второй строковый массив размером равным первому массиву, который будет принимать элемнты из первого строкового массива с помощью цикла.
# 3. Применение цикла:
для заполнения второго строкового массива с помощью цикла пересчитываем колличество символов в элементе, и если количество символов не больше трех, добавляем такой элемент во второй массив. Если символов больше трех, игнорируем такой элемент и переходим к проверке следующего.
# 4. Выведение результата:
на экран выводим первоначальный массив и второй заполненный массив.

Готовая работа хранится в ветке master.
