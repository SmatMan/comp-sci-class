import time
import os
import random
from pyfiglet import figlet_format


options = ["rock", "paper", "scissors"]

def clear_scroll(lines=0):
    if lines == 0:
        lines = os.get_terminal_size()[1]
    for i in range(lines-3):
        time.sleep(0.3)
        print("\n")
    os.system("clear")

def get_user_choice():
    choice = input("\nEnter your choice: ").lower()
    if choice not in options:
        print("Invalid choice")
        return get_user_choice()
    return choice

def get_computer_choice():
    return options[random.randint(0, 2)]

def compare_choices(user_choice, computer_choice):
    if user_choice == computer_choice:
        return 0
    elif user_choice == "rock":
        if computer_choice == "paper":
            return False
        else:
            return True
    elif user_choice == "paper":
        if computer_choice == "scissors":
            return False
        else:
            return True
    elif user_choice == "scissors":
        if computer_choice == "rock":
            return False
        else:
            return True

if __name__ == "__main__":
    os.system("clear")
    text = figlet_format("Rock Paper Scissors")
    print(text)
    # get height of text in console
    height = text.count("\n")
 
    time.sleep(2)
    clear_scroll(height)
    while True:
        print("Options: " + ", ".join([option.capitalize() for option in options]))
        time.sleep(1)
        user_choice = get_user_choice()
        computer_choice = get_computer_choice()
        os.system("clear")
        print("You chose:")
        print(figlet_format(user_choice.capitalize()))
        time.sleep(1)
        print(f"Computer chose:")
        print(figlet_format(computer_choice.capitalize()))
        time.sleep(1.5)
        winner = compare_choices(user_choice, computer_choice)
        os.system("clear")
        print("Results:")
        if winner == 0:
            print(figlet_format("Tie"))
        elif winner:
            print(figlet_format("You win!"))
        else:
            print(figlet_format("You lose!"))
        
        print(figlet_format(f"{user_choice.capitalize()} vs {computer_choice.capitalize()}"))
        

        time.sleep(1)
        play_again = input("\nWould you like to play again? (y/n): ").lower()
        if play_again != "y":
            break
        os.system("clear")