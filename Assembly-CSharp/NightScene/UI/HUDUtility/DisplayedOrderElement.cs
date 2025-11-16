using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001CB RID: 459
	public class DisplayedOrderElement : MonoBehaviour
	{
		// Token: 0x060039AB RID: 14763 RVA: 0x001634BC File Offset: 0x001616BC
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayedOrderElement()
		{
			Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "DisplayedOrderElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr);
			DisplayedOrderElement.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "first");
			DisplayedOrderElement.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "second");
			DisplayedOrderElement.NativeFieldInfoPtr_third = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "third");
			DisplayedOrderElement.NativeFieldInfoPtr_fg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "fg");
			DisplayedOrderElement.NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "bg");
			DisplayedOrderElement.NativeFieldInfoPtr_trimFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "trimFront");
			DisplayedOrderElement.NativeFieldInfoPtr_trimBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "trimBack");
			DisplayedOrderElement.NativeFieldInfoPtr_statusIndicatorUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "statusIndicatorUp");
			DisplayedOrderElement.NativeFieldInfoPtr_statusIndicatorDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "statusIndicatorDown");
			DisplayedOrderElement.NativeFieldInfoPtr_indicatorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, "indicatorPosition");
			DisplayedOrderElement.NativeMethodInfoPtr_set_Indicator_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674055);
			DisplayedOrderElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674056);
			DisplayedOrderElement.NativeMethodInfoPtr_Initialize_Public_Void_Sprite_Sprite_Color_Color_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674057);
			DisplayedOrderElement.NativeMethodInfoPtr_Initialize_Public_Void_Sprite_IndicatorPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674058);
			DisplayedOrderElement.NativeMethodInfoPtr_SetHighlight_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674059);
			DisplayedOrderElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674060);
			DisplayedOrderElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr, 100674061);
		}

		// Token: 0x170013EC RID: 5100
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x00163640 File Offset: 0x00161840
		public unsafe Sprite Indicator
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 131537, RefRangeEnd = 131539, XrefRangeStart = 131528, XrefRangeEnd = 131537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayedOrderElement.NativeMethodInfoPtr_set_Indicator_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x00163684 File Offset: 0x00161884
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayedOrderElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x001636B8 File Offset: 0x001618B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131568, RefRangeEnd = 131569, XrefRangeStart = 131539, XrefRangeEnd = 131568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Sprite first, Sprite second, Color fg, Color bg, Sprite trimBack, Sprite trimFront)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bg;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimBack);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimFront);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayedOrderElement.NativeMethodInfoPtr_Initialize_Public_Void_Sprite_Sprite_Color_Color_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x00163750 File Offset: 0x00161950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131580, RefRangeEnd = 131582, XrefRangeStart = 131569, XrefRangeEnd = 131580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Sprite single, DisplayedOrderElement.IndicatorPosition indicatorPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(single);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicatorPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayedOrderElement.NativeMethodInfoPtr_Initialize_Public_Void_Sprite_IndicatorPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x001637A0 File Offset: 0x001619A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131582, XrefRangeEnd = 131584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlight(Sprite indicatorVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indicatorVisual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayedOrderElement.NativeMethodInfoPtr_SetHighlight_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x001637E4 File Offset: 0x001619E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131584, XrefRangeEnd = 131593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayedOrderElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00163820 File Offset: 0x00161A20
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayedOrderElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayedOrderElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayedOrderElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0002045E File Offset: 0x0001E65E
		public DisplayedOrderElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x0016385C File Offset: 0x00161A5C
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x00020467 File Offset: 0x0001E667
		public unsafe Image first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_first);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x0016388C File Offset: 0x00161A8C
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x00020486 File Offset: 0x0001E686
		public unsafe Image second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_second);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x001638BC File Offset: 0x00161ABC
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x000204A5 File Offset: 0x0001E6A5
		public unsafe Image third
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_third);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_third), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x001638EC File Offset: 0x00161AEC
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x000204C4 File Offset: 0x0001E6C4
		public unsafe Image fg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_fg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_fg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x0016391C File Offset: 0x00161B1C
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x000204E3 File Offset: 0x0001E6E3
		public unsafe Image bg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_bg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x0016394C File Offset: 0x00161B4C
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x00020502 File Offset: 0x0001E702
		public unsafe Image trimFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_trimFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_trimFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x0016397C File Offset: 0x00161B7C
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00020521 File Offset: 0x0001E721
		public unsafe Image trimBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_trimBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_trimBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x001639AC File Offset: 0x00161BAC
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x00020540 File Offset: 0x0001E740
		public unsafe Image statusIndicatorUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_statusIndicatorUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_statusIndicatorUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x001639DC File Offset: 0x00161BDC
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x0002055F File Offset: 0x0001E75F
		public unsafe Image statusIndicatorDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_statusIndicatorDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_statusIndicatorDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x00163A0C File Offset: 0x00161C0C
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x0002057E File Offset: 0x0001E77E
		public unsafe DisplayedOrderElement.IndicatorPosition indicatorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_indicatorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayedOrderElement.NativeFieldInfoPtr_indicatorPosition)) = value;
			}
		}

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeFieldInfoPtr_second;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeFieldInfoPtr_third;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeFieldInfoPtr_fg;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeFieldInfoPtr_bg;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeFieldInfoPtr_trimFront;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeFieldInfoPtr_trimBack;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeFieldInfoPtr_statusIndicatorUp;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeFieldInfoPtr_statusIndicatorDown;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeFieldInfoPtr_indicatorPosition;

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeMethodInfoPtr_set_Indicator_Public_set_Void_Sprite_0;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Sprite_Sprite_Color_Color_Sprite_Sprite_0;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Sprite_IndicatorPosition_0;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlight_Public_Void_Sprite_0;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000948 RID: 2376
		public enum IndicatorPosition
		{
			// Token: 0x04007839 RID: 30777
			Up,
			// Token: 0x0400783A RID: 30778
			Down
		}
	}
}
