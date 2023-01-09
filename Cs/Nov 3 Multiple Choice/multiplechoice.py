# comparing c# program to python program
import os
import time

questions = [
    ["What language was this program written in?", ["C#", "C++", "Java", "Python"], "4"],
    ["What is the name of the IDE used to write this program?", ["Visual Studio", "PyCharm", "Visual Studio Code", "NetBeans"], "3"],
    ["What method do you use if an if statement is false?", ["else", "elif", "if", "then"], "1"],
    ["What is the name of the method used to print to the console?", ["print", "write", "display", "output"], "1"],
    ["What is the name of the method used to get user input?", ["input", "get", "read", "scan"], "1"],
]
score = 0

for question in questions:
    os.system("clear")
    print(question[0])
    for j in range(len(question[1])):
        print(f"{j+1}) {question[1][j]}")
    answer = input("Enter your answer: ")
    if answer == question[2]:
        print("Correct!")
        score+=1
    else:
        print("Incorrect!")

    time.sleep(1)

print(f"\nCongrats! Your score is {score}/{len(questions)}")