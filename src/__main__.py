from tkinter import *
import Objects
class App(Frame):
    def __init__(self, master=None):
        Frame.__init__(self, master)
        self.pack()


app = App()

app.master.title("Snake")
app.master.maxsize(750,750)
app.master.minsize(750,750)

app.mainloop()
