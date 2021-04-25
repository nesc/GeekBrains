Select ROUND(LONG_W,4) 
  from STATION 
 where LAT_N = (Select MIN(LAT_N) 
                  from STATION
                 where LAT_N > '38.7780');