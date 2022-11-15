users = ["John", "Mary", "Bob", "Sue"]
query = input("Who would you like to search for?: ").lower()
for index, name in enumerate(users):
    if query in name.lower():
        print(f"Found user {name} at index {index+1}")
        