using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000156 RID: 342
	public class DS_NPC_Pos_Override : PlayableAsset
	{
		// Token: 0x06002731 RID: 10033 RVA: 0x001213E4 File Offset: 0x0011F5E4
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Override()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Override");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr);
			DS_NPC_Pos_Override.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr, "characterLabel");
			DS_NPC_Pos_Override.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr, "mapLabel");
			DS_NPC_Pos_Override.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr, "position");
			DS_NPC_Pos_Override.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr, "rotation");
			DS_NPC_Pos_Override.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr, 100670248);
			DS_NPC_Pos_Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr, 100670249);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0012148C File Offset: 0x0011F68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90817, XrefRangeEnd = 90837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Override.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x001214F4 File Offset: 0x0011F6F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Override>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000171AC File Offset: 0x000153AC
		public DS_NPC_Pos_Override(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x00121530 File Offset: 0x0011F730
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x000171B5 File Offset: 0x000153B5
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x00121558 File Offset: 0x0011F758
		// (set) Token: 0x06002738 RID: 10040 RVA: 0x000171D4 File Offset: 0x000153D4
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x00121580 File Offset: 0x0011F780
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x000171F3 File Offset: 0x000153F3
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x001215A8 File Offset: 0x0011F7A8
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x0001720E File Offset: 0x0001540E
		public unsafe DayScenePlayerInputGenerator.CharacterRotation rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Override.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
