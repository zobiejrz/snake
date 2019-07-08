import tkinter
from tkinter import *
class App(Frame):
    def __init__(self, master=None):
        Frame.__init__(self, master)
        self.pack()

# ========= WINDOW =========
window = App()
window.master.title("Snake")
window.master.maxsize(500,500)
window.master.minsize(500,500)
app = tkinter.Frame(window, height=480, width=480)
app.pack(fill="both", expand=True, padx=20, pady=20)

# ========= GAME FRAME =========
game_frame = tkinter.Frame(app, height=400, width=400, bg='black')
game_frame.pack(side = TOP)

# ========= SCORE FRAME =========
score_frame = tkinter.Frame(app, height=40, width=80)

# TITLE (this won't change, it's always going to say 'Score : ')
title = Label(score_frame, text="Score : ")
title.pack(side = LEFT)

# SCORE (this will change, it's the score)
score = Label(score_frame, text="0000")
score.pack(side = LEFT)
score_frame.pack(side = LEFT)



window.mainloop()
