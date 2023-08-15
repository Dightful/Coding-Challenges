class Rectangle:
	def __init__(self, x, y, width, height):
		self.x = x
		self.y = y
		self.width = width
		self.height = height
	def intersecting(self, self2):
		rectange1_top = [self.x, (self.x + self.width), ((self.x + self.width) - self.x)]
		rectange1_side = [self.y, (self.y - self.height), (self.y - (self.y - self.height))]
		rectange2_top = [self2.x, (self2.x + self2.width), ((self2.x + self2.width) - self2.x)]
		rectange2_side = [self2.y, (self2.y - self2.height), (self2.y - (self2.y - self2.height))]

		if (rectange1_side[0] <= rectange2_top[1] and rectange1_side[0] >= rectange2_side[1]) or (rectange1_side[1] <= rectange2_top[1] and rectange1_side[1] >= rectange2_side[1]):
			if (rectange2_top[0] <= rectange1_side[0] and rectange2_top[0] >= rectange1_top[0]) or (rectange2_side[0] <= rectange1_side[0] and rectange2_side[0] >= rectange1_top[0]):
				print("True")
			else:
				print("False")
		else:
			print("False")

a = Rectangle(10, 20, 100, 20)
b = Rectangle(10, 40, 15, 20)
c = Rectangle(50, 50, 20, 30)

Rectangle.intersecting(b, c)
