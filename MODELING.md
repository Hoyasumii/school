@UserType
- Student
- Teacher
- Coordinator
- Director

User
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Director][IF:User.Length=0_THEN:createdBy=this.id])
- firstName@string[DefinedString]
- lastName@string[DefinedString]
- birthDate@date[DateTime]
- email@string[Email]
- password@string[Password]
- type@string[UserType]([IF:User.Length=0_THEN:type=Director])

Subject
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- name@string[DefinedString]
- description@string[DefinedString]

Class
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- subjectId@uuid[GuidVO](Subject.id)
- teacherId@string[GuidVO](User.id[WHERE:type=Teacher])
- name@string[DefinedString]
- academicYear@int[Year]
- semester@int[Semester]

StudentEnrollment
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- studentId@uuid[GuidVO](User.id[WHERE:type=Student])
- classId@uuid[GuidVO](Class.id)

ClassAssignment
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- classId@uuid[GuidVO](Class.id)
- name@string[DefinedString]

StudentGrade
- id@uuid[GuidVO]
- publishedBy@uuid[GuidVO](User.id[WHERE:type=Teacher])
- studentId@uuid[GuidVO](User.id[WHERE:type=Student])
- classAssignmentId@uuid[GuidVO](ClassAssignment.id)
- grade@double[Grade]

# NEXT
AvisosDisciplinares
- id@uuid
- disciplinaId@uuid[GuidVO](Disciplina.id)
- conteúdo@string[DefinedString]

MateriaisDisciplinares
- id@uuid
- disciplinaId@uuid[GuidVO](Disciplina.id)
- conteúdo@string[DefinedString]
- referências@array->string[Array<Link>]

- [ ] Adicionar um sistema de faltas