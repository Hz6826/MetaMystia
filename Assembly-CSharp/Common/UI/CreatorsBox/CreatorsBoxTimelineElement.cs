using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x020003CE RID: 974
	public class CreatorsBoxTimelineElement : MonoBehaviour
	{
		// Token: 0x06007412 RID: 29714 RVA: 0x00221588 File Offset: 0x0021F788
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorsBoxTimelineElement()
		{
			Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.CreatorsBox", "CreatorsBoxTimelineElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr);
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_CenterVisual_Start");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_CenterVisual_Normal");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_SpecialGuestElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_SpecialGuestElement");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_AvailableIndicator1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_AvailableIndicator1");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_AvailableIndicator2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_AvailableIndicator2");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_TimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_TimeStamp");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_CenterVisual");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_LeftLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_LeftLine");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_RightLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_RightLine");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_NormalColor");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_ExtraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_ExtraColor");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NullGuestParentNameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_NullGuestParentNameColor");
			CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NullGuestParentAvatarMaskColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "m_NullGuestParentAvatarMaskColor");
			CreatorsBoxTimelineElement.NativeMethodInfoPtr_Setup_Public_Void_Int32_Boolean_Boolean_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, 100687168);
			CreatorsBoxTimelineElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, 100687169);
			CreatorsBoxTimelineElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, 100687170);
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x002216F8 File Offset: 0x0021F8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289342, RefRangeEnd = 289343, XrefRangeStart = 289223, XrefRangeEnd = 289342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(int timeStamp, bool isEnd, bool isExtra, bool nextIsExtra, SpecialGuest specialGuest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeStamp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isExtra;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextIsExtra;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.NativeMethodInfoPtr_Setup_Public_Void_Int32_Boolean_Boolean_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x00221774 File Offset: 0x0021F974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreatorsBoxTimelineElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x002217B0 File Offset: 0x0021F9B0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorsBoxTimelineElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x0003ED13 File Offset: 0x0003CF13
		public CreatorsBoxTimelineElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x06007417 RID: 29719 RVA: 0x002217EC File Offset: 0x0021F9EC
		// (set) Token: 0x06007418 RID: 29720 RVA: 0x0003ED1C File Offset: 0x0003CF1C
		public unsafe Sprite m_CenterVisual_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual_Start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x06007419 RID: 29721 RVA: 0x0022181C File Offset: 0x0021FA1C
		// (set) Token: 0x0600741A RID: 29722 RVA: 0x0003ED3B File Offset: 0x0003CF3B
		public unsafe Sprite m_CenterVisual_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600741B RID: 29723 RVA: 0x0022184C File Offset: 0x0021FA4C
		// (set) Token: 0x0600741C RID: 29724 RVA: 0x0003ED5A File Offset: 0x0003CF5A
		public unsafe UIElementCluster m_SpecialGuestElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_SpecialGuestElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_SpecialGuestElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x0022187C File Offset: 0x0021FA7C
		// (set) Token: 0x0600741E RID: 29726 RVA: 0x0003ED79 File Offset: 0x0003CF79
		public unsafe CanvasGroup m_AvailableIndicator1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_AvailableIndicator1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_AvailableIndicator1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600741F RID: 29727 RVA: 0x002218AC File Offset: 0x0021FAAC
		// (set) Token: 0x06007420 RID: 29728 RVA: 0x0003ED98 File Offset: 0x0003CF98
		public unsafe CanvasGroup m_AvailableIndicator2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_AvailableIndicator2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_AvailableIndicator2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x06007421 RID: 29729 RVA: 0x002218DC File Offset: 0x0021FADC
		// (set) Token: 0x06007422 RID: 29730 RVA: 0x0003EDB7 File Offset: 0x0003CFB7
		public unsafe TextMeshProUGUI m_TimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_TimeStamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_TimeStamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x06007423 RID: 29731 RVA: 0x0022190C File Offset: 0x0021FB0C
		// (set) Token: 0x06007424 RID: 29732 RVA: 0x0003EDD6 File Offset: 0x0003CFD6
		public unsafe Image m_CenterVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_CenterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x06007425 RID: 29733 RVA: 0x0022193C File Offset: 0x0021FB3C
		// (set) Token: 0x06007426 RID: 29734 RVA: 0x0003EDF5 File Offset: 0x0003CFF5
		public unsafe Image m_LeftLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_LeftLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_LeftLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x0022196C File Offset: 0x0021FB6C
		// (set) Token: 0x06007428 RID: 29736 RVA: 0x0003EE14 File Offset: 0x0003D014
		public unsafe Image m_RightLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_RightLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_RightLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x06007429 RID: 29737 RVA: 0x0022199C File Offset: 0x0021FB9C
		// (set) Token: 0x0600742A RID: 29738 RVA: 0x0003EE33 File Offset: 0x0003D033
		public unsafe Color m_NormalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NormalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NormalColor)) = value;
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x0600742B RID: 29739 RVA: 0x002219C4 File Offset: 0x0021FBC4
		// (set) Token: 0x0600742C RID: 29740 RVA: 0x0003EE4E File Offset: 0x0003D04E
		public unsafe Color m_ExtraColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_ExtraColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_ExtraColor)) = value;
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x002219EC File Offset: 0x0021FBEC
		// (set) Token: 0x0600742E RID: 29742 RVA: 0x0003EE69 File Offset: 0x0003D069
		public unsafe Color m_NullGuestParentNameColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NullGuestParentNameColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NullGuestParentNameColor)) = value;
			}
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x00221A14 File Offset: 0x0021FC14
		// (set) Token: 0x06007430 RID: 29744 RVA: 0x0003EE84 File Offset: 0x0003D084
		public unsafe Color m_NullGuestParentAvatarMaskColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NullGuestParentAvatarMaskColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.NativeFieldInfoPtr_m_NullGuestParentAvatarMaskColor)) = value;
			}
		}

		// Token: 0x04004CE8 RID: 19688
		private static readonly IntPtr NativeFieldInfoPtr_m_CenterVisual_Start;

		// Token: 0x04004CE9 RID: 19689
		private static readonly IntPtr NativeFieldInfoPtr_m_CenterVisual_Normal;

		// Token: 0x04004CEA RID: 19690
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestElement;

		// Token: 0x04004CEB RID: 19691
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableIndicator1;

		// Token: 0x04004CEC RID: 19692
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableIndicator2;

		// Token: 0x04004CED RID: 19693
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeStamp;

		// Token: 0x04004CEE RID: 19694
		private static readonly IntPtr NativeFieldInfoPtr_m_CenterVisual;

		// Token: 0x04004CEF RID: 19695
		private static readonly IntPtr NativeFieldInfoPtr_m_LeftLine;

		// Token: 0x04004CF0 RID: 19696
		private static readonly IntPtr NativeFieldInfoPtr_m_RightLine;

		// Token: 0x04004CF1 RID: 19697
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalColor;

		// Token: 0x04004CF2 RID: 19698
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraColor;

		// Token: 0x04004CF3 RID: 19699
		private static readonly IntPtr NativeFieldInfoPtr_m_NullGuestParentNameColor;

		// Token: 0x04004CF4 RID: 19700
		private static readonly IntPtr NativeFieldInfoPtr_m_NullGuestParentAvatarMaskColor;

		// Token: 0x04004CF5 RID: 19701
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Int32_Boolean_Boolean_Boolean_SpecialGuest_0;

		// Token: 0x04004CF6 RID: 19702
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004CF7 RID: 19703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F61 RID: 3937
		[ObfuscatedName("Common.UI.CreatorsBox.CreatorsBoxTimelineElement+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x060111E8 RID: 70120 RVA: 0x003F331C File Offset: 0x003F151C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_recorded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, "recorded");
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_specialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, "specialGuest");
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, "colorScheme");
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, "pixel");
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687171);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687172);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687173);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687174);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687175);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687176);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687177);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687178);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687179);
				CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr, 100687180);
			}

			// Token: 0x060111E9 RID: 70121 RVA: 0x003F3474 File Offset: 0x003F1674
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111EA RID: 70122 RVA: 0x003F34B0 File Offset: 0x003F16B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111EB RID: 70123 RVA: 0x003F34F4 File Offset: 0x003F16F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111EC RID: 70124 RVA: 0x003F3538 File Offset: 0x003F1738
			[CallerCount(0)]
			public unsafe void _Setup_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111ED RID: 70125 RVA: 0x003F357C File Offset: 0x003F177C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111EE RID: 70126 RVA: 0x003F35C0 File Offset: 0x003F17C0
			[CallerCount(0)]
			public unsafe void _Setup_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111EF RID: 70127 RVA: 0x003F3604 File Offset: 0x003F1804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289204, XrefRangeEnd = 289209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111F0 RID: 70128 RVA: 0x003F3648 File Offset: 0x003F1848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289209, XrefRangeEnd = 289214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111F1 RID: 70129 RVA: 0x003F368C File Offset: 0x003F188C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289214, XrefRangeEnd = 289217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111F2 RID: 70130 RVA: 0x003F36D0 File Offset: 0x003F18D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289217, XrefRangeEnd = 289220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060111F3 RID: 70131 RVA: 0x00094DE6 File Offset: 0x00092FE6
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005901 RID: 22785
			// (get) Token: 0x060111F4 RID: 70132 RVA: 0x003F3714 File Offset: 0x003F1914
			// (set) Token: 0x060111F5 RID: 70133 RVA: 0x00094DEF File Offset: 0x00092FEF
			public unsafe bool recorded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_recorded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_recorded)) = value;
				}
			}

			// Token: 0x17005902 RID: 22786
			// (get) Token: 0x060111F6 RID: 70134 RVA: 0x003F373C File Offset: 0x003F193C
			// (set) Token: 0x060111F7 RID: 70135 RVA: 0x00094E0A File Offset: 0x0009300A
			public unsafe CreatorsBoxTimelineElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorsBoxTimelineElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005903 RID: 22787
			// (get) Token: 0x060111F8 RID: 70136 RVA: 0x003F376C File Offset: 0x003F196C
			// (set) Token: 0x060111F9 RID: 70137 RVA: 0x00094E29 File Offset: 0x00093029
			public unsafe SpecialGuest specialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_specialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_specialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005904 RID: 22788
			// (get) Token: 0x060111FA RID: 70138 RVA: 0x003F379C File Offset: 0x003F199C
			// (set) Token: 0x060111FB RID: 70139 RVA: 0x00094E48 File Offset: 0x00093048
			public unsafe Il2CppStructArray<Color> colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_colorScheme);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_colorScheme), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005905 RID: 22789
			// (get) Token: 0x060111FC RID: 70140 RVA: 0x003F37CC File Offset: 0x003F19CC
			// (set) Token: 0x060111FD RID: 70141 RVA: 0x00094E67 File Offset: 0x00093067
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorsBoxTimelineElement.__c__DisplayClass13_0.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD2D RID: 44333
			private static readonly IntPtr NativeFieldInfoPtr_recorded;

			// Token: 0x0400AD2E RID: 44334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AD2F RID: 44335
			private static readonly IntPtr NativeFieldInfoPtr_specialGuest;

			// Token: 0x0400AD30 RID: 44336
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x0400AD31 RID: 44337
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400AD32 RID: 44338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD33 RID: 44339
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__0_Internal_Void_Image_0;

			// Token: 0x0400AD34 RID: 44340
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__1_Internal_Void_Image_0;

			// Token: 0x0400AD35 RID: 44341
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD36 RID: 44342
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD37 RID: 44343
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AD38 RID: 44344
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__8_Internal_Void_Image_0;

			// Token: 0x0400AD39 RID: 44345
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__9_Internal_Void_Image_0;

			// Token: 0x0400AD3A RID: 44346
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__10_Internal_Void_Image_0;

			// Token: 0x0400AD3B RID: 44347
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__11_Internal_Void_Image_0;
		}

		// Token: 0x02000F62 RID: 3938
		[ObfuscatedName("Common.UI.CreatorsBox.CreatorsBoxTimelineElement+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060111FE RID: 70142 RVA: 0x003F37FC File Offset: 0x003F19FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorsBoxTimelineElement>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr);
				CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, "<>9");
				CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, "<>9__13_2");
				CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, "<>9__13_3");
				CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, "<>9__13_4");
				CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, 100687182);
				CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__Setup_b__13_2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, 100687183);
				CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__Setup_b__13_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, 100687184);
				CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__Setup_b__13_4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr, 100687185);
			}

			// Token: 0x060111FF RID: 70143 RVA: 0x003F38C8 File Offset: 0x003F1AC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorsBoxTimelineElement.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011200 RID: 70144 RVA: 0x003F3904 File Offset: 0x003F1B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__13_2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__Setup_b__13_2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011201 RID: 70145 RVA: 0x003F3948 File Offset: 0x003F1B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__13_3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__Setup_b__13_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011202 RID: 70146 RVA: 0x003F398C File Offset: 0x003F1B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289220, XrefRangeEnd = 289223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Setup_b__13_4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorsBoxTimelineElement.__c.NativeMethodInfoPtr__Setup_b__13_4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011203 RID: 70147 RVA: 0x00094E86 File Offset: 0x00093086
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005906 RID: 22790
			// (get) Token: 0x06011204 RID: 70148 RVA: 0x003F39D0 File Offset: 0x003F1BD0
			// (set) Token: 0x06011205 RID: 70149 RVA: 0x00094E8F File Offset: 0x0009308F
			public unsafe static CreatorsBoxTimelineElement.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorsBoxTimelineElement.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005907 RID: 22791
			// (get) Token: 0x06011206 RID: 70150 RVA: 0x003F39F8 File Offset: 0x003F1BF8
			// (set) Token: 0x06011207 RID: 70151 RVA: 0x00094EA1 File Offset: 0x000930A1
			public unsafe static Action<Image> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005908 RID: 22792
			// (get) Token: 0x06011208 RID: 70152 RVA: 0x003F3A20 File Offset: 0x003F1C20
			// (set) Token: 0x06011209 RID: 70153 RVA: 0x00094EB3 File Offset: 0x000930B3
			public unsafe static Action<Image> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005909 RID: 22793
			// (get) Token: 0x0601120A RID: 70154 RVA: 0x003F3A48 File Offset: 0x003F1C48
			// (set) Token: 0x0601120B RID: 70155 RVA: 0x00094EC5 File Offset: 0x000930C5
			public unsafe static Action<TextMeshProUGUI> __9__13_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorsBoxTimelineElement.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AD3C RID: 44348
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AD3D RID: 44349
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x0400AD3E RID: 44350
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x0400AD3F RID: 44351
			private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

			// Token: 0x0400AD40 RID: 44352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AD41 RID: 44353
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__13_2_Internal_Void_Image_0;

			// Token: 0x0400AD42 RID: 44354
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__13_3_Internal_Void_Image_0;

			// Token: 0x0400AD43 RID: 44355
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__13_4_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
