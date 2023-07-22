import { Component } from '@angular/core';

@Component({
  selector: 'app-notification-list',
  templateUrl: './notification-list.component.html',
  styleUrls: ['./notification-list.component.scss']
})
export class NotificationListComponent {

  notificationList: any[] = [
    {
      title: 'Nova mensagem',
      from: 'João Silva',
      message: 'Você recebeu uma nova mensagem de João Silva.',
      date: '25 de Junho, 2023'
    },
    {
      title: 'Atualização do sistema',
      from: 'Admin',
      message: 'Uma nova atualização do sistema está disponível. Por favor, atualize para a versão mais recente.',
      date: '24 de Junho, 2023'
    },
    {
      title: 'Lembrete de reunião',
      from: 'Maria Souza',
      message: 'Lembrete: Reunião de equipe às 14h. Não se esqueça de participar.',
      date: '23 de Junho, 2023'
    }
  ];
}


