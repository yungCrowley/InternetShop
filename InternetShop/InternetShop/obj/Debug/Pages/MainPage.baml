   M S B A M L   `   `   `  ����G  CInternetShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:InternetShop.PagesInternetShop.Pages  5      !    InternetShop.Pages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:InternetShop.Pages     5      -   5        $	��850��5	      $
��1200��6     N� Title$  MainPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   .+�5      �� $G��AC:\games\diplom\InternetShop\InternetShop\image\модель1.jpg��6   5      �� 5      $>��8C:\games\diplom\InternetShop\InternetShop\image\Logo.png��6   $	��200��5      $	��Top=�5      $	��300��5      $��	0 0 150 0q�5      �� 5   
   $��1��6   .+�5      �� $G��AC:\games\diplom\InternetShop\InternetShop\image\модель2.jpg��6   5      �� 5      
�������$��5��5      $
��auto��5       $	��Top=�5!       �� Orientation$ 
Horizontal=�5"      $��0��5#      $��2��5$      $��Center=�5%      ��5&      �� 5'       �� 
TargetType" ��6    �� Triggers 5(      :� 5)       :� RoutedEvent$ 
MouseEnter��6+   [�5*   "   �� 5+   &   .��5,   *   �� .��5-   .   W�  g� Duration$ 0:0:0.2D�6>    �� TargetProperty$ Height�5.   >   	 W� To$	 100X�5/   >   51   /   52   +   53   '   55      :� 56      $ 
MouseLeave��6+   [�57   "   �� 58   &   .��59   *   �� .��5:   .   W� $ 0:0:0.2D�6>   $ Height�5;   >   $ 5X�5<   >   5=   +   5>   '   5@      5B      .+�5D      �� -   5        	 ��Name$	 AddBtn��5D      $��Добавить��5E      $	��150��5F      $��50��5G      
�������
���   �$��Center=�5J      $��0 0 10 0q�5K      5L      �� 5N      -   5        $	 ManCloth��5N      $��Мужчины��5O      $	��150��5P      $��50��5Q      $��18(�5R      
�������
���   �$��Center=�5U      $��Center=�5V      $��0 0 10 0q�5W      5X      �� 5Z      -   5        $	 
WomanCloth��5Z      $��Женщины��5[      $	��150��5\      $��50��5]      $��18(�5^      
�������
���   �$��Center=�5a      $��Center=�5b      $��0 0 10 0q�5c      5d      �� 5e      -   5        $	 
LimitedBtn��5e      $"��Лимитированное��5f      $	��150��5g      $��50��5h      $��18(�5i      
�������
���   �$��Center=�5l      $��Center=�5m      $��0 0 10 0q�5n      5o      �� 5p      -   5        $	 HelpBtn��5p      $��Помощь��5q      $	��150��5r      $��50��5s      $��18(�5t      
�������
���   �$��Center=�5w      $��Center=�5x      $��0 0 10 0q�5y      5z      �� 5{      -   5        
 ��Name$
 MaxPeice��5{      �� 5|      -   5        $
 MinPrice��5|      5}      5~      5      