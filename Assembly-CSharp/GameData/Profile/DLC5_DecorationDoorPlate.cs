using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.EventUtility;

namespace GameData.Profile
{
	// Token: 0x02000312 RID: 786
	public class DLC5_DecorationDoorPlate : DecorationBase
	{
		// Token: 0x06005D45 RID: 23877 RVA: 0x001D4A9C File Offset: 0x001D2C9C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_DecorationDoorPlate()
		{
			Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC5_DecorationDoorPlate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr);
			DLC5_DecorationDoorPlate.NativeFieldInfoPtr_buffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr, "buffType");
			DLC5_DecorationDoorPlate.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr, 100682522);
			DLC5_DecorationDoorPlate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr, 100682523);
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x001D4B08 File Offset: 0x001D2D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233178, XrefRangeEnd = 233195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_DecorationDoorPlate.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x001D4B58 File Offset: 0x001D2D58
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_DecorationDoorPlate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_DecorationDoorPlate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x00032E45 File Offset: 0x00031045
		public DLC5_DecorationDoorPlate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06005D49 RID: 23881 RVA: 0x001D4B94 File Offset: 0x001D2D94
		// (set) Token: 0x06005D4A RID: 23882 RVA: 0x00032E4E File Offset: 0x0003104E
		public unsafe DLC5_DecorationDoorPlate.DoorPlateType buffType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_DecorationDoorPlate.NativeFieldInfoPtr_buffType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_DecorationDoorPlate.NativeFieldInfoPtr_buffType)) = value;
			}
		}

		// Token: 0x04003DB6 RID: 15798
		private static readonly IntPtr NativeFieldInfoPtr_buffType;

		// Token: 0x04003DB7 RID: 15799
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003DB8 RID: 15800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D34 RID: 3380
		public enum DoorPlateType
		{
			// Token: 0x04009AF2 RID: 39666
			Constant,
			// Token: 0x04009AF3 RID: 39667
			Constant
		}

		// Token: 0x02000D35 RID: 3381
		[ObfuscatedName("GameData.Profile.DLC5_DecorationDoorPlate+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600F341 RID: 62273 RVA: 0x00399928 File Offset: 0x00397B28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_DecorationDoorPlate>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr);
				DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr, "<>9");
				DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr, "<>9__2_0");
				DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr, "<>9__2_1");
				DLC5_DecorationDoorPlate.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr, 100682525);
				DLC5_DecorationDoorPlate.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__2_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr, 100682526);
				DLC5_DecorationDoorPlate.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__2_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr, 100682527);
			}

			// Token: 0x0600F342 RID: 62274 RVA: 0x003999CC File Offset: 0x00397BCC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_DecorationDoorPlate.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_DecorationDoorPlate.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F343 RID: 62275 RVA: 0x00399A08 File Offset: 0x00397C08
			[CallerCount(0)]
			public unsafe string _DecorationBuffEnterNight_b__2_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_DecorationDoorPlate.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__2_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F344 RID: 62276 RVA: 0x00399A50 File Offset: 0x00397C50
			[CallerCount(0)]
			public unsafe string _DecorationBuffEnterNight_b__2_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_DecorationDoorPlate.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__2_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F345 RID: 62277 RVA: 0x0008294F File Offset: 0x00080B4F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F15 RID: 20245
			// (get) Token: 0x0600F346 RID: 62278 RVA: 0x00399A98 File Offset: 0x00397C98
			// (set) Token: 0x0600F347 RID: 62279 RVA: 0x00082958 File Offset: 0x00080B58
			public unsafe static DLC5_DecorationDoorPlate.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_DecorationDoorPlate.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F16 RID: 20246
			// (get) Token: 0x0600F348 RID: 62280 RVA: 0x00399AC0 File Offset: 0x00397CC0
			// (set) Token: 0x0600F349 RID: 62281 RVA: 0x0008296A File Offset: 0x00080B6A
			public unsafe static Func<string, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F17 RID: 20247
			// (get) Token: 0x0600F34A RID: 62282 RVA: 0x00399AE8 File Offset: 0x00397CE8
			// (set) Token: 0x0600F34B RID: 62283 RVA: 0x0008297C File Offset: 0x00080B7C
			public unsafe static Func<string, string> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_DecorationDoorPlate.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AF4 RID: 39668
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009AF5 RID: 39669
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04009AF6 RID: 39670
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04009AF7 RID: 39671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AF8 RID: 39672
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__2_0_Internal_String_String_0;

			// Token: 0x04009AF9 RID: 39673
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__2_1_Internal_String_String_0;
		}
	}
}
