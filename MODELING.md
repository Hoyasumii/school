@c -> customizable
@d -> default

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
- email@string[Email]@c
- password@string[Password]@c
- type@string[UserType]([IF:User.Length=0_THEN:type=Director])@c
- address@Address@c

Subject
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- name@string[DefinedString]@c
- description@string[DefinedString]@c

Class
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- subjectId@uuid[GuidVO](Subject.id)
- teacherId@string[GuidVO](User.id[WHERE:type=Teacher])@c
- name@string[DefinedString]@c
- academicYear@int[Year]@c
- semester@int[Semester]@c
- active@boolean@d->true

StudentEnrollment
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- studentId@uuid[GuidVO](User.id[WHERE:type=Student])
- classId@uuid[GuidVO](Class.id)

ClassAssignment
- id@uuid[GuidVO]
- createdBy@uuid[GuidVO](User.id[WHERE:type=Coordinator])
- classId@uuid[GuidVO](Class.id)
- name@string[DefinedString]@c

StudentGrade
- id@uuid[GuidVO]
- publishedBy@uuid[GuidVO](User.id[WHERE:type=Teacher])
- studentId@uuid[GuidVO](User.id[WHERE:type=Student])
- classAssignmentId@uuid[GuidVO](ClassAssignment.id)
- grade@double[Grade]@c

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