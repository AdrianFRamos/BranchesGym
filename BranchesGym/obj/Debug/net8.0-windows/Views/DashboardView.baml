   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   F BBranchesGym, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BranchesGym.ViewsBranchesGym.Views 5   	   %   BranchesGym.Views.DashboardView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Clc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   1viewsclr-namespace:BranchesGym.Views     5   	     � Title$  Dashboard - Branches Gym��5   	   $	��800��6*   $
��1400��67   ���#1E1E2F.��5      �  � ColumnDefinitions 5	   
   �� 5
      $	��250 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   #  BranchesGym.Views.SidebarView  $��0��6   $��2��6,   � 5   
   $��1��6   $��0��6   ���#2A2A3C 5      �� 5      $��* �6#   �� 5      $	��200 �6#   .+�5      �� $��	Dashboard��6   $��20(�6)   $
��Bold"�67   
�������$��Center=�6\   $��20,0,0,0q�6w   �� 5        �� Orientation$ 
Horizontal=�6   $��1��62   $��Right=�6B   $��Center=�6^   $��0,0,20,0q�6y   .+�5!      �� $��	Jhonathan��6   
�������$��0,0,10,0q�6@   $��Center=�6R   �� 5"      $��Profile��6   
�������
������ 
������ $��0,0,10,0q�6q   �� 5#      $��Logout��6   
�������
������ 
������ 6V   5$      5%      �� 5(   
   $��1��6   $��1��6'   $
��Auto=�64   .��5)      �� $��20q�6   .+�5+      �� $ 
Horizontal=�6   $��Center=�66   $��0,0,0,20q�6S   .+�5,      �� ���#FFC107$	��200��62   $	��100��6>    �� CornerRadius$ 10��6K   $��10q�6]   ._�5-      �� $��Center=�6%   $��Center=�6@   .+�5.      �� $	��193��6(   $��24(�63   $
��Bold"�6A   
���   �6S   �� 5/      $��Clientes sem treino��6(   $��14(�6C   
���   �6Q   50      51      �� 52      ���#28A745$	��200��62   $	��100��6>   $ 10��6K   $��10q�6]   ._�53      �� $��Center=�6%   $��Center=�6@   .+�54      �� $��28��6(   $��24(�62   $
��Bold"�6@   
���   �6R   �� 55      $��Treinos expirados��6(   $��14(�6A   
���   �6O   56      57      �� 58      ���#007BFF$	��200��62   $	��100��6>   $ 10��6K   $��10q�6]   ._�59      �� $��Center=�6%   $��Center=�6@   .+�5:      �� $��0��6(   $��24(�61   $
��Bold"�6?   
���   �6Q   �� 5;      $��Chamadas realizadas��6(   $��14(�6C   
���   �6Q   5<      5=      5>      �� 5A      $��Gráficos de Desempenho��6   $��18(�6:   $
��Bold"�6H   
�������$��0,0,0,10q�6m   #   LiveCharts.Wpf.CartesianChart  5B      $	��300��6$   $��10q�61   &    LiveCharts.Wpf.Charts.Base.Chart   Series 5D      !   LiveCharts.Wpf.ColumnSeries     LiveCharts.Wpf.Series   Title$ Clientes Ativos��6*      Values;   5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 10,20,30,40,50 6B   5F        5G      $	��300��6$   $��10q�61    5I         LiveCharts.Wpf.LineSeries  $ 	Progresso��6(   $ 5,15,25,35,45 6:   5K      5L      5M      5N      5O      