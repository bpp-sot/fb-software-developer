# --- POOR CODE QUALITY SCRIPT (WHAT MAKES IT POOR?) ---
x=0;s=""
while 1:
        a=input("what is it? ")
        if a=="exit":
          break
        else:
              b=input("type: ")
              c=int(input("time: "))
              x=x+c;s=s+"Task: "+a+" | Cat: "+b+" | Mins: "+str(c)+"\n"
              print("saved")
print("\n--- DAILY WORK LOG ---")
print(s)
print("----------------------------")
print("Total Duration: "+str(x)+" minutes")