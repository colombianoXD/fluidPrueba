"""Sums in loop"""
L1 = [851071, 768888]
L2 = [751669, 853984]
L3 = [121267, 931823]
L4 = [425183, 821702]
L5 = [728363, 373628]
L6 = [80893, 179624]
L7 = [363094, 127833]
L8 = [596976, 772068]
L9 = [336120, 196703]
L10 = [54818, 883845]
L11 = [253376, 170337]
L12 = [394009, 307650]
L13 = [441460, 179763]
L14 = [286410, 511151]
L15 = [788323, 217161]

LF = [L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14, L15]
LR = []

for i in range(15):
    AC = 0
    for e in range(2):

        AC += LF[i][e]

    LR.append(AC)
    print LR[i]
