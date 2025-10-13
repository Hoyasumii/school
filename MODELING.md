@c -> customizable
@d -> default
@u -> unique

@UserType
- Student
- Teacher
- Coordinator
- Director
- Admin

<!-- TODO: Eu alterei um elemento de User. Ajeitar todos os serviços de domínio + refatoração nas interfaces e nas implementações -->

<!--
Na inicialização do sistema, verificar se existe um usuário Admin.
Se não tiver, criar um usuário:

User {
  name: {
    firstName: "School",
    lastName: "System"
  },
  birthDate: DateTime.Now,
  email: "generic-email@school.me",
  password: hash("Password-123"),
  type: Admin,
  address: {
    zipCode: "123",
    state: "Sergipe",
    city: "Aracaju",
    neighborhood: "Aeroporto",
    street: "Rua ...",
    number: 97
  }
}
-->

<!-- #region SUPPORT -->

<!--
UserInvite
> Responsável por dar a permissão para criar um novo usuário
- Pode ser criado apenas por diretores e pelo admin
- O Convite só pode criar Coordenadores, Professores e Alunos
-->

UserInvite
- id@uuid[GuidVO]
- invitedBy@uuid[GuidVO](User.id[WHERE:type=Director])
- type@string[UserType]@d->Student

<!-- 
User
> Agente central do projeto
- Após ser criado, remover o registro de UserInvite
- Se não houver registros além do admin, o type sempre será Diretor
- O seu id sempre será o que veio de UserInvite
[STUDENT]
- Se for removido, remover todos StudentEnrollment ligados a ele
- Não pode mudar de tipo
[TEACHER]
- Só pode ser removido caso não tenham Turmas vinculadas a ele
- Pode se tornar Coordenador ou Diretor
[COORDINATOR]
- Só pode ser removido caso não tenham Cursos vinculados a ele
- Pode se tornar Professor ou Diretor
[DIRECTOR]
- Não pode ser removido
- Pode se tornar Professor ou Coordenador
[ADMIN]
- Não pode ser removido
- Não pode mudar de tipo
-->

User
- id@uuid[GuidVO]@d->UserInvite.id
- firstName@string[DefinedString]
- lastName@string[DefinedString]
- birthDate@date[DateTime]
- email@string[Email]@c@u
- password@string[Password]@c
- type@string[UserType]([IF:User.Length=0_THEN:type=Director])@c
- address@Address[Address]@c

<!-- #endregion SUPPORT -->

<!-- #region CORE -->

<!--
Course
> Responsável por agrupar disciplinas com turmas, e os alunos que estão nela.
- Só pode ser criado por diretores
- Só pode ser editado por diretores
- Só pode ser removido se não tiverem Disciplinas vinculadas ativas
- Se for removido, [REMOVE] todas as disciplinas
- Se for removido, [REMOVE] todos os StudentEnrollment
-->

Course
- id@uuid[GuidVO]
- coordinatorId@uuid[GuidVO](User.id[WHERE:type=Coordinator])@c
- name@string[DefinedString]@c

<!-- 
Subject
> Responsável por declarar a disciplina
- Só pode ser criado por Coordenadores
- Só pode ser editado por Coordenadores
- Só pode ser removido se não tiverem Turmas vinculadas ativas
- Se for removido, [REMOVE] todas as Turmas
-->

Subject
- id@uuid[GuidVO]
- name@string[DefinedString]@c
- description@string[DefinedString]@c
- courseId@uuid[GuidVO](Course.id)
- active@boolean@c@d->true

<!--
Class
> Responsável por fazer uso da disciplina e organizar adequadamente
- Só pode ser criado por Coordenadores
- Só pode ser editado por Coordenadores
- Caso o ano e o semestre passe, o estado de ativo ficará desativado, e não poderá ser alterado
- Se for removido, [REMOVE] todos os ClassAssignment

[ROUTINE]
- Verificar no dia 1 de todo início de semestre para mudar o estado de ativo para falso
-->

Class
- id@uuid[GuidVO]
- subjectId@uuid[GuidVO](Subject.id)
- teacherId@string[GuidVO](User.id[WHERE:type=Teacher])@c
- name@string[DefinedString]@c
- academicYear@int[Year]@c
- semester@int[Semester]@c
- active@boolean@c@d->true

<!--
StudentEnrollment
> Responsável por vincular o usuário ao curso
- Só pode ser criado e removido por Coordenadores
- Se for removido, [REMOVE] todos os StudentGrade
-->

StudentEnrollment
- id@uuid[GuidVO]
- studentId@uuid[GuidVO](User.id[WHERE:type=Student])
- courseId@uuid[GuidVO](Course.id)

<!--
ClassAssignment
> Responsável por declarar a pontuação d'uma determinada turma
- Só pode ser criado, editado e removido por um Professor
- Se for removido, [REMOVE] todos os StudentGrade
-->

ClassAssignment
- id@uuid[GuidVO]
- classId@uuid[GuidVO](Class.id)
- name@string[DefinedString]@c

<!--
StudentGrade
> Responsável por exibir a pontuação que um determinado aluno tirou num ClassAssignment
- Só pode ser criado, editado e removido por um Professor
-->

StudentGrade
- id@uuid[GuidVO]
- studentEnrollmentId@uuid[GuidVO](StudentEnrollment.id)
- classAssignmentId@uuid[GuidVO](ClassAssignment.id)
- grade@double[Grade]@c

<!-- #endregion CORE -->

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
- [ ] Adicionar um sistema de notificação para Usuários