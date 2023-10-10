

### Query to fetch courses details, Just specify the properties/columns
```
{
  courses {
    id
    name
    description
  }
}
```


### Add Items using mutation on UI

```
mutation{
  addCourse(course:{name:"Course Name Example", description:"course descripion", review:8, dateAdded:"2023-10-10T06:08:45.1134476Z"
    , dateUpdated:"2023-10-10T06:08:45.1244476Z"}){
    id, 
    name, 
    description, 
    review, 
    dateAdded, 
    dateUpdated    
  }
}
```


### Update Items using mutation on UI

```
mutation{
  updateCourse(id:1, course:{name:"Updated Course Name Example", description:"Updated course descripion", 
    	review:2, 
    dateAdded:"2023-10-10T06:08:45.1134476Z"
    , dateUpdated:"2023-10-10T06:08:45.1244476Z"}){
    id, 
    name, 
    description    
  }
}
```

### Delete a Item using mutation on UI
```
mutation{
  deleteCourse(id:1){
    id
  }
}
```

### Get data with related entities
```
{
  courses {
    id
    name
    description,
	reviews{
	rate,
	comment
	}
  }
}
```

### Mutation to add relational data




