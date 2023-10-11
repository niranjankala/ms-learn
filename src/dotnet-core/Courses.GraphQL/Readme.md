

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
```
mutation{
  addCourse(course:{name:"Welcome Course ", description:"course descripion", dateAdded:"2023-10-10T06:08:45.1134476Z"
    , dateUpdated:"2023-10-10T06:08:45.1244476Z",
    reviews:[
      {
        rate:5,
        comment: "rate of 5"
      },
      {
        rate:7,
        comment: "rate of 7"
      }
    ]
  	}){
    id, 
    name, 
    description,     
    dateAdded, 
    dateUpdated,
    reviews{
      rate,
      comment
    },     
  }
}
```


