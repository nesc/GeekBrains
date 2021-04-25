Select c.NAME
  from CITY c
  join COUNTRY ct
    on ct.CODE = c.COUNTRYCODE
   and ct.CONTINENT = 'Africa';