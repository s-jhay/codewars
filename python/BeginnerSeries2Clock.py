def past(h, m, s):
    result = (s * 1000)
    result += (m * 60000)
    result += (h * 3600000)
    
    return result
