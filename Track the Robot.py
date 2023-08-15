def trackRobot(steps):
	movement  = [0,0]
	for i in range(len(steps)):
		if i == 0 :
			movement[1] = movement[1] + steps[i] 
		if i == 1: 
			movement[0] = movement[0] + steps[i]
		if i == 2: 
			movement[1] = movement[1] - steps[i] 
		if i == 3: 
			movement[0] = movement[0] - steps[i]
	print(movement)

trackRobot([20, 30, 10, 40])