using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x0200044E RID: 1102
	public class COM_KaguyaMokouSpecial : PlayableAsset
	{
		// Token: 0x060079BD RID: 31165 RVA: 0x002322A4 File Offset: 0x002304A4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_KaguyaMokouSpecial()
		{
			Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_KaguyaMokouSpecial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr);
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_missionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "missionLabel");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_firstItemTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "firstItemTicks");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_secondItemTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "secondItemTicks");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_equalTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "equalTicks");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_setAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "setAchievements");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedMokouWinLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "recordedMokouWinLabel");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedKaguyaWinLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "recordedKaguyaWinLabel");
			COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedEqualLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, "recordedEqualLabel");
			COM_KaguyaMokouSpecial.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, 100687756);
			COM_KaguyaMokouSpecial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr, 100687757);
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x0023239C File Offset: 0x0023059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294206, XrefRangeEnd = 294236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_KaguyaMokouSpecial.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00232404 File Offset: 0x00230604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_KaguyaMokouSpecial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_KaguyaMokouSpecial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_KaguyaMokouSpecial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00041C2F File Offset: 0x0003FE2F
		public COM_KaguyaMokouSpecial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x00232440 File Offset: 0x00230640
		// (set) Token: 0x060079C2 RID: 31170 RVA: 0x00041C38 File Offset: 0x0003FE38
		public unsafe string missionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_missionLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_missionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x00232468 File Offset: 0x00230668
		// (set) Token: 0x060079C4 RID: 31172 RVA: 0x00041C57 File Offset: 0x0003FE57
		public unsafe int firstItemTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_firstItemTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_firstItemTicks)) = value;
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x00232490 File Offset: 0x00230690
		// (set) Token: 0x060079C6 RID: 31174 RVA: 0x00041C72 File Offset: 0x0003FE72
		public unsafe int secondItemTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_secondItemTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_secondItemTicks)) = value;
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x002324B8 File Offset: 0x002306B8
		// (set) Token: 0x060079C8 RID: 31176 RVA: 0x00041C8D File Offset: 0x0003FE8D
		public unsafe int equalTicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_equalTicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_equalTicks)) = value;
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x002324E0 File Offset: 0x002306E0
		// (set) Token: 0x060079CA RID: 31178 RVA: 0x00041CA8 File Offset: 0x0003FEA8
		public unsafe bool setAchievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_setAchievements);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_setAchievements)) = value;
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x00232508 File Offset: 0x00230708
		// (set) Token: 0x060079CC RID: 31180 RVA: 0x00041CC3 File Offset: 0x0003FEC3
		public unsafe string recordedMokouWinLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedMokouWinLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedMokouWinLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x060079CD RID: 31181 RVA: 0x00232530 File Offset: 0x00230730
		// (set) Token: 0x060079CE RID: 31182 RVA: 0x00041CE2 File Offset: 0x0003FEE2
		public unsafe string recordedKaguyaWinLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedKaguyaWinLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedKaguyaWinLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x060079CF RID: 31183 RVA: 0x00232558 File Offset: 0x00230758
		// (set) Token: 0x060079D0 RID: 31184 RVA: 0x00041D01 File Offset: 0x0003FF01
		public unsafe string recordedEqualLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedEqualLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_KaguyaMokouSpecial.NativeFieldInfoPtr_recordedEqualLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005017 RID: 20503
		private static readonly IntPtr NativeFieldInfoPtr_missionLabel;

		// Token: 0x04005018 RID: 20504
		private static readonly IntPtr NativeFieldInfoPtr_firstItemTicks;

		// Token: 0x04005019 RID: 20505
		private static readonly IntPtr NativeFieldInfoPtr_secondItemTicks;

		// Token: 0x0400501A RID: 20506
		private static readonly IntPtr NativeFieldInfoPtr_equalTicks;

		// Token: 0x0400501B RID: 20507
		private static readonly IntPtr NativeFieldInfoPtr_setAchievements;

		// Token: 0x0400501C RID: 20508
		private static readonly IntPtr NativeFieldInfoPtr_recordedMokouWinLabel;

		// Token: 0x0400501D RID: 20509
		private static readonly IntPtr NativeFieldInfoPtr_recordedKaguyaWinLabel;

		// Token: 0x0400501E RID: 20510
		private static readonly IntPtr NativeFieldInfoPtr_recordedEqualLabel;

		// Token: 0x0400501F RID: 20511
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04005020 RID: 20512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
