using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200013F RID: 319
	public class DS_NPC_Pos_Override_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600262D RID: 9773 RVA: 0x0011E854 File Offset: 0x0011CA54
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Override_Behaviour()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Override_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr);
			DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr, "characterLabel");
			DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr, "mapLabel");
			DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr, "position");
			DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr, "rotation");
			DS_NPC_Pos_Override_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr, 100670168);
			DS_NPC_Pos_Override_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr, 100670169);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0011E8FC File Offset: 0x0011CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90158, XrefRangeEnd = 90163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Override_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0011E938 File Offset: 0x0011CB38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Override_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Override_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Override_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0001687B File Offset: 0x00014A7B
		public DS_NPC_Pos_Override_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x0011E974 File Offset: 0x0011CB74
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x00016884 File Offset: 0x00014A84
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x0011E99C File Offset: 0x0011CB9C
		// (set) Token: 0x06002634 RID: 9780 RVA: 0x000168A3 File Offset: 0x00014AA3
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x0011E9C4 File Offset: 0x0011CBC4
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x000168C2 File Offset: 0x00014AC2
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x0011E9EC File Offset: 0x0011CBEC
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x000168DD File Offset: 0x00014ADD
		public unsafe int rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override_Behaviour.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
